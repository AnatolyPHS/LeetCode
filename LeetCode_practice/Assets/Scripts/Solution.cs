using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start() {
        string result = GetPermutation(4,9);
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

        int[] tmpArray = new int[inputArray.Length];
        inputArray.CopyTo(tmpArray, 0);
        
        int currentArrayValue = CalculateValue(tmpArray);
        for (int i = tmpArray.Length - 1; i >= 0 ; i--){
            for (int j = i - 1; j >= 0; j--){
                int tmp = tmpArray[i];
                tmpArray[i] = tmpArray[j];
                tmpArray[j] = tmp;
                int nextMinValue =  CalculateValue(tmpArray);

                if (currentArrayValue > nextMinValue){
                    tmp = tmpArray[i];
                    tmpArray[i] = tmpArray[j];
                    tmpArray[j] = tmp;
                    continue;
                }

                return GetPermutatedArrayAtStep(tmpArray, step);
            }
        }

        return  inputArray;
    }

    private int CalculateValue(int[] inputArray){
        int finalSumm = 0;
        for(int i = inputArray.Length - 1; i >= 0 ; i--){
            finalSumm += inputArray[i] * Power(10, (inputArray.Length - i - 1));
        }

        return finalSumm;
    }
    
    private int Power(int baseValue, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }

        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseValue;
        }
        return result;
    }
}
