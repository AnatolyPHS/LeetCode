using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start()
    {
        string[] words = {"This", "is", "an", "example", "of", "text", "justification."};
        /*string[] words = {"What","must","be","acknowledgment","shall","be"};*/
        int maxWidth = 16;
        IList<string> result = FullJustify(words, maxWidth);
        foreach( string line in result)
        {
            Debug.Log(line);
        }
    }

    private int maxWordWidth = -1;
    
    public IList<string> FullJustify(string[] words, int maxWidth) {
        IList<string> result = new List<string>();
        List<string> newLine = new List<string>();

        maxWordWidth = maxWidth;

        int charInLineNumber = 0;
        int numberOfSymbols = 0;
        for(int i = 0; i < words.Length; i++){
            string word = words[i];
            bool isLastWord = i == words.Length - 1;

            if (word.Length == maxWidth){
                result.Add(word);
                continue;
            }
            
            if (charInLineNumber + (newLine.Count - 1)+ word.Length <= maxWidth - 1)
            {
                newLine.Add(word);
                numberOfSymbols += word.Length;
                if (isLastWord == false)
                {
                    continue;
                }
            }

            result.Add(ConvertListToWord(newLine,numberOfSymbols));
            charInLineNumber = word.Length;
            numberOfSymbols = 0;
            newLine.Clear();
            newLine.Add(word);

            if (isLastWord)
            {
                result.Add(ConvertListToWord(newLine,numberOfSymbols)); 
            }
        }
        
        result[^1] = ProcessLastLine(result.Last());
        return result;
    }

    private string ProcessLastLine(string word)
    {
        string[] words = word.Split(' ');
        word = string.Join(" ", words);
        int spacesToAdd = maxWordWidth - word.Length;
        string endSpaces = new string(' ', spacesToAdd);
        return (word + endSpaces);
    }

    private string ConvertListToWord(List<string> newLine, int wordsLength)
    {
        string finalWord = string.Empty; // need a builder
        int spacesToAdd = maxWordWidth - wordsLength;
        int spacesNeeded = newLine.Count - 1;
        int spacesPerPosition = spacesNeeded == 0 ? spacesToAdd : spacesToAdd / spacesNeeded;
        int excessiveSpaces =  spacesNeeded == 0 ? 0 : spacesToAdd % spacesNeeded;

        for (int i = 0; i < newLine.Count; i++)
        {
            finalWord = finalWord + newLine[i];
            string onlySpaces = new string(' ', spacesPerPosition  + excessiveSpaces > 0 ? 1 : 0);
            if (i < newLine.Count - 1)
            {
                finalWord += onlySpaces;
            }

            excessiveSpaces--;
        }
        
        return finalWord;
    }
}
