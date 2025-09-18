using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start() {
        /*string s = "adceb";
        string p = "*a*b";*/
        /*string s = "aa";
        string p = "a";*/
        string s = "aa";
        string p = "*";
        bool result = IsMatch(s, p);
        Debug.Log(result); 
    }
    
    public bool IsMatch(string s, string p)
    {
        bool[,] finalMatchTable = new bool[s.Length + 1, p.Length + 1];
        finalMatchTable[0, 0] = true;

        for (int i = 1; i <= p.Length; i++)
        {
            if (p[i - 1] == '*')
            {
                finalMatchTable[0, i] = finalMatchTable[0, i - 1];
            }
            else
            {
                break;
            }
        }

        for (int i = 1; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                if (p[j - 1] == '*')
                {
                    finalMatchTable[i, j] = finalMatchTable[i - 1, j] || finalMatchTable[i, j - 1];
                    continue;
                }

                if (p[j - 1] == '?' || s[i - 1] == p[j - 1])
                {
                    finalMatchTable[i ,j] = finalMatchTable[i - 1, j - 1];
                }
            }
        }

        PrintTable(finalMatchTable);
        return finalMatchTable[s.Length, p.Length]; 
    }

    private void PrintTable(bool[,] matchArray)
    {
        string table = "";
        for (int i = 0; i < matchArray.GetLength(0); i++)
        {
            for (int j = 0; j < matchArray.GetLength(1); j++)
            {
                table += matchArray[i, j] ? "T " : "F ";
            }
            table += "\n";
        }
        Debug.Log(table);
    }
}
