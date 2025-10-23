using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start()
    {
        MinWindow("ADOBECODEBANC", "ABC");
    }

    public string MinWindow(string s, string t)
    {
        int tLength = t.Length;
        int sLength = s.Length;

        if (tLength > sLength)
        {
            return "";
        }

        for (int frameLength = tLength; frameLength <= sLength; frameLength++)
        {
            for (int i = 0; i <= s.Length - frameLength; i++)
            {
                string subString = s.Substring(i, frameLength);
                if (HasAllLetters(subString, t))
                {
                    return subString;
                }
            }
        }


        return "";
    }

    private bool HasAllLetters(string InputString, string lettersToHave)
    {
        Dictionary<char, int> lettersInQueryString = new Dictionary<char, int>();
        for (int i = 0; i < InputString.Length; i++)
        {
            char letter = InputString[i];
            if (lettersInQueryString.Keys.Contains(letter)){
                lettersInQueryString[letter]++;
            }
            else
            {
                lettersInQueryString.Add(letter, 1);
            }
        }

        for (int i = 0; i < lettersToHave.Length; i++)
        {
            char letterToHave = lettersToHave[i];
            if (lettersInQueryString.Keys.Contains(letterToHave) == false 
                || lettersInQueryString[letterToHave] <= 0)
            {
                return false;
            }

            lettersInQueryString[letterToHave]--;
        }

        return true;
    }
}
