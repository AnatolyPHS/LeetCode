using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start() {
        string s = "adceb";
        string p = "*a*b";
        /*string s = "aa";
        string p = "a";*/
        bool result = IsMatch(s, p);
        Debug.Log(result); 
    }
    
    public bool IsMatch(string s, string p) {
        if (p.Length > s.Length)
        {
            int asterixNumber = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '*')
                {
                    asterixNumber++;
                }
            }

            if (p.Length - asterixNumber > s.Length)
            {
                return false;
            }
        }
        
          bool[,] matchArray = new bool[s.Length, p.Length];

          bool isAsterix = false; 
          
          for (int j = p.Length - 1; j >= 0; j--)
          {
              char patternSymbol = p[j];
              isAsterix = patternSymbol == '*';
              int stepsProcessed = (p.Length - 1 - j);
              for (int i = s.Length - 1 - stepsProcessed; i >= 0 ; i--)
              {
                    matchArray[i,j] = patternSymbol == s[i] || isAsterix || patternSymbol == '?';
                    if (isAsterix == false)
                    {
                        break;
                    }
              }
          }

          bool hasMatch = false;

          hasMatch = FindPath(matchArray);

          return hasMatch; 
    }

    private bool FindPath( bool[,] matchArray){
        int rows = matchArray.GetLength(0);
        int columns = matchArray.GetLength(1);
        if (rows == 1 &&  columns == 1){
            return matchArray[0,0];
        }

        if ((rows > 1 && columns > 1) && matchArray[rows - 2, columns - 2] == true){
            bool[,] tmpArray = RemoveLastRow(RemoveLastColumn(matchArray));
            if (FindPath(tmpArray)){
                return true;
            }
        }

        if ( columns > 1 && matchArray[rows - 1, columns - 2] == true){
            bool[,] tmpArray = RemoveLastColumn(matchArray);
            if (FindPath(tmpArray)){
                return true;
            }
        }

        if (rows > 1 && matchArray[rows - 2, columns - 1] == true){
            bool[,] tmpArray = RemoveLastRow(matchArray);
            if (FindPath(tmpArray)){
                return true;
            }
        }

        return false;
    }

    private bool[,] RemoveLastRow(bool[,] array){
        bool[,] finalArray = new bool[array.GetLength(0) - 1,array.GetLength(1)];

        for (int i = 0; i <array.GetLength(0) - 1; i++){
            for(int j = 0; j < array.GetLength(1); j++){
                finalArray[i,j] = array[i,j];
            }
        }

        return finalArray;
    }

    private bool[,] RemoveLastColumn(bool[,] array){
        bool[,] finalArray = new bool[array.GetLength(0),array.GetLength(1) - 1];

        for (int i = 0; i < array.GetLength(0); i++){
            for(int j = 0; j < array.GetLength(1) - 1; j++){
                finalArray[i,j] = array[i,j];
            }
        }

        return finalArray;
    }
}
