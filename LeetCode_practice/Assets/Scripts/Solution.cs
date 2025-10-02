using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start()
    {
        /*IsNumber("-.E3"); // should be false*/
        /*IsNumber("-.E3");// should be false*/
        IsNumber("+.8");// should be true
    }
    
private HashSet<char> digits = new HashSet<char>();
    
    public bool IsNumber(string s) {
                
        for (char c = '0'; c <= '9'; c++)
        {
            digits.Add(c);
        }

        int dotPositionIndex = -1;
        int ePositionIndex = -1;
        int plusminusPositionIndex = -1;
        int stringLastIndex = s.Length - 1;
        int digitsCount = 0;

        if (stringLastIndex == 0){
            return digits.Contains(s[0]);
        }

        for(int i = stringLastIndex; i >= 0 ; i --){
            char symbol = s[i];

            if (digits.Contains(symbol)){
                digitsCount++;
                continue;
            }

            if (symbol == 'e' || symbol == 'E'){
                if (i == stringLastIndex){
                    return false;
                }

                if (i == 0){
                    return false;
                }
                
                if (ePositionIndex != -1) {
                    return false;
                }
                ePositionIndex = i;
            }
            else if (symbol == '-' || symbol == '+'){
                if (i == 0){
                    continue;
                }

                if (plusminusPositionIndex != -1){
                    return false;
                }

                plusminusPositionIndex = i;
            }
            else if (symbol == '.'){
                if (dotPositionIndex != -1){
                    return false;
                }

                dotPositionIndex = i;
            }
            else
            {
                return false;
            }
        }

        if (digitsCount == 0){
            return false;
        }

        return SpecialSymbolsInProperPositions(plusminusPositionIndex, dotPositionIndex, ePositionIndex, s);

    }

    private bool SpecialSymbolsInProperPositions(int plusminusPositionIndex,
     int dotPositionIndex,int ePositionIndex, string s)
    {
        bool positionsAreFine = true;
        int lastPosition = s.Length - 1;

        if (plusminusPositionIndex != -1){
            positionsAreFine &= plusminusPositionIndex != lastPosition && digits.Contains(s[plusminusPositionIndex + 1])
            && ePositionIndex == plusminusPositionIndex - 1;
        }
        
        bool theFirstSymbolIsSign = s[0] == '-' || s[0] == '+';
        
        if (dotPositionIndex != -1){
            positionsAreFine &= (dotPositionIndex == lastPosition) || (digits.Contains(s[dotPositionIndex + 1])) 
                                                                   || ePositionIndex == dotPositionIndex + 1;
        }

        if (theFirstSymbolIsSign && lastPosition>= 1)
        {
            positionsAreFine &= (digits.Contains(s[1]) || dotPositionIndex == 1);
            if (dotPositionIndex == 1)
            {
                positionsAreFine &= ePositionIndex != 2;
            }
        }

        if (dotPositionIndex == 0 && lastPosition>= 1)
        {
            positionsAreFine &= digits.Contains(s[1]);
        }
        
        if (ePositionIndex != -1){
            positionsAreFine &= ePositionIndex != 0;
            positionsAreFine &= ePositionIndex != lastPosition;
            positionsAreFine &= (theFirstSymbolIsSign == false) || ePositionIndex > 1;

            if (positionsAreFine == false)
            {
                return false;
            }

            bool ePatterIsFine = (digits.Contains(s[ePositionIndex + 1]) ||
                                  (ePositionIndex + 1 == plusminusPositionIndex &&
                                   plusminusPositionIndex != lastPosition &&
                                   digits.Contains(s[plusminusPositionIndex + 1])));
            
            positionsAreFine &= ePatterIsFine;
            positionsAreFine &= ePositionIndex > dotPositionIndex;
        }

        return positionsAreFine;
    }
}
