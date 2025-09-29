using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start() {
    }
    
    private HashSet<char> digits = new HashSet<char>;
    
    public bool IsNumber(string s) {
        for (char c = '0'; c <= '9'; c++)
        {
            digits.Add(c);
        }

        int dotPositionIndex = -1;
        int ePositionIndex = -1;
        int plusminusPositionIndex = -1;
        int stringLastIndex = s.Length - 1;

        for(int i = stringLastIndex; i >= 0 ; i --){
            char symbol = s[i];

            if (digits.Contains(symbol)){
                continue;
            }

            if (symbol == 'e' || symbol == 'E'){
                if(i == stringLastIndex){
                    retunr false;
                }

                if (i == 0){
                    return false;
                }
                
                if (ePositionIndex != -1) {
                    return false;
                }
                ePositionIndex = i;
            }

            if (symbol == '-' || symbol == '+'){
                if (i == 0){
                    continue;
                }

                if (plusminusPositionIndex != -1){
                    return false;
                }

                plusminusPositionIndex = i;
            }

            if (symbol == '.'){
                if (dotPositionIndex != -1){
                    return false;
                }

                dotPositionIndex = i;
            }
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
                                                                       && ;
        }
        

        return positionsAreFine;
    }
}
