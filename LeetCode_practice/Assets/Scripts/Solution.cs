using UnityEngine;

public class Solution : MonoBehaviour
{
    private void Start()
    {
        int[] nums = new int[] { 1, 2, 0 };
        FirstMissingPositive(nums);
    }
    
    public int FirstMissingPositive(int[] nums) {
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;


        for (int i = 0 ; i < nums.Length; i++){
            int currentValue = nums[i];
            if (currentValue < 0){
                continue;
            }

            if (minValue > currentValue){
                minValue = currentValue;
            }

            if (maxValue < currentValue){
                maxValue = currentValue;
            }
        }

        if (minValue > 1 || minValue <= 0) {
            return 1;
        }

        int smallestPositive = minValue;

        for (int i = 0 ; i < nums.Length; i++){
            
        }

        return smallestPositive;
    }
}
