using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start()
    {
    }
    
    public IList<string> FullJustify(string[] words, int maxWidth) {
        IList<string> result = new List<string>();
        List<string> newLine = new List<string>();

        int charInLineNumber = 0;
        for(int i = 0; i < words.Length; i++){
            string word = words[i];

            if (word.Lenght == maxWidth){
                result.Add(word);
                continue;
            }

            if (charInLineNumber + word.Length <= maxWidth - 1){
                newLine.Add(word)
                charInLineNumber += 1;
                charInLineNumber += word.Length;
                continue;
            }

            result.Add(ConvertListToWord(newLine));
            charInLineNumber = word.Length;
            newLine.Clear()
            newLine.Add(word);
        }

        ProcessLastLine(result);

        return result;
    }
}
