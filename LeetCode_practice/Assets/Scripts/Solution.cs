using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{    
    private void Start() {
        string result = GetPermutation(4,9);
        Debug.Log(result);
    }
    
    public string GetPermutation(int n, int k) {
        List<int> numbers = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            numbers.Add(i);
        }
        
        int[] factorials = new int[n];
        factorials[0] = 1;
        for (int i = 1; i < n; i++)
        {
            factorials[i] = factorials[i - 1] * i;
        }
        
        k--;
        
        string result =  "";
        
        for (int i = n - 1; i >= 0; i--)
        {
            int index = k / factorials[i];
            result = result + numbers[index].ToString();
            numbers.RemoveAt(index);

            k %= factorials[i];
        }

        return result.ToString();
    }
}
