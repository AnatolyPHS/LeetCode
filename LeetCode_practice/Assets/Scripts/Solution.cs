using System;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start() {
        string result = GetPermutation(3,3);
        Debug.Log(result);
    }
    
    public string GetPermutation(int n, int k) {
        int[] numbers = new int[n];
        for (int i = 1 ; i <= n; i++){
            numbers[i - 1] = i;
        }

        int[] final =  GetPermutatedArrayAtStep(numbers, k);

        string result = "";
        for (int i = 0; i < final.Length; i++){
            result += final[i].ToString();
        }

        return result;
    }

    private int[] GetPermutatedArrayAtStep(int[] inputArray, int step){
        if (step == 0){
            return inputArray;
        }
        step--;

        int currentArrayValue = CalculateValue(inputArray);

        for (int i = 0; i < inputArray.Length; i++){
            for (int j = i + 1; j < inputArray.Length; j++){
                int tmp = inputArray[i];
                inputArray[i] = inputArray[j];
                inputArray[j] = tmp;
                int nextMinValue =  CalculateValue(inputArray);

                if (currentArrayValue > nextMinValue){
                    tmp = inputArray[i];
                    inputArray[i] = inputArray[j];
                    inputArray[j] = tmp;
                    continue;
                }

                return GetPermutatedArrayAtStep(inputArray, step);
            }
        }

        return  inputArray;
    }

    private int CalculateValue(int[] inputArray){
        int finalSumm = 0;
        for(int i = inputArray.Length - 1; i >= 0 ; i--){
            finalSumm += inputArray[i] * 10^i;
        }

        return finalSumm;
    }
}
