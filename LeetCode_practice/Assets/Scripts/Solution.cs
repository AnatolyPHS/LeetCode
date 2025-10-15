using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start()
    {
        /*string[] words = {"This", "is", "an", "example", "of", "text", "justification."};*/
        /*string[] words = {"What","must","be","acknowledgment","shall","be"};*/
        string[] words = {"What","must","be","shall","be."};
        int maxWidth = 5;
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
                if (newLine.Count > 0)
                {
                    result.Add(ConvertListToWord(newLine,numberOfSymbols));
                    newLine.Clear();
                    numberOfSymbols = 0;
                }
                result.Add(word);
                continue;
            }
            
            if (numberOfSymbols + (newLine.Count - 1)+ word.Length <= maxWidth - 1)
            {
                newLine.Add(word);
                numberOfSymbols += word.Length;
                word = String.Empty;
                if (isLastWord == false)
                {
                    continue;
                }
            }

            if (isLastWord)
            {
                result.Add(ConvertListToWord(newLine,numberOfSymbols));
                if (string.IsNullOrEmpty(word) == false)
                {
                    result.Add(ConvertListToWord(new List<string>(){word},word.Length));
                }
                break;
            }
            
            result.Add(ConvertListToWord(newLine,numberOfSymbols));
            
            numberOfSymbols = word.Length;
            newLine.Clear();
            newLine.Add(word);
        }
        
        result[^1] = ProcessLastLine(result.Last());
        return result;
    }

    private string ProcessLastLine(string word)
    {
        string[] words = word.Split(' ');
        List<string> realWords = words.ToList().Where(w => w != "").ToList();
        word = string.Join(" ", realWords);
        int spacesToAdd = maxWordWidth - word.Length;
        string endSpaces = new string(' ', spacesToAdd);
        return (word + endSpaces);
    }

    private string ConvertListToWord(List<string> newLine, int wordsLength)
    {
        string finalWord = string.Empty; // need a builder
        int spacesToAdd = maxWordWidth - wordsLength;
        int intermediateSpacePositionsNumber = newLine.Count - 1;
        int spacesPerPosition = intermediateSpacePositionsNumber == 0 ? spacesToAdd : spacesToAdd / intermediateSpacePositionsNumber;
        int excessiveSpaces =  intermediateSpacePositionsNumber == 0 ? 0 : spacesToAdd % intermediateSpacePositionsNumber;

        if (newLine.Count == 1)
        {
            string onlySpaces = new string(' ', spacesToAdd);
            return newLine[0] + onlySpaces;
        }
        
        for (int i = 0; i < newLine.Count; i++)
        {
            finalWord = finalWord + newLine[i];
            string onlySpaces = new string(' ', spacesPerPosition  + (excessiveSpaces > 0 ? 1 : 0));
            if (i < newLine.Count - 1)
            {
                finalWord += onlySpaces;
            }

            excessiveSpaces--;
        }
        
        return finalWord;
    }
}
