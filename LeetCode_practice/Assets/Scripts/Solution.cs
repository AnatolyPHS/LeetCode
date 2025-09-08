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
            if (currentValue <= 0){
                continue;
            }

            if (minValue > currentValue){
                minValue = currentValue;
            }

            if (maxValue < currentValue){
                maxValue = currentValue;
            }
        }

        if (minValue > 1) {
            return 1;
        }

        int minValueSecondLap = minValue;
        int maxValueSecondLap = maxValue;

        for (int i = 0 ; i < nums.Length; i++){
            if (nums[i] <= 0){
                continue;
            }
            
            if(nums[i] == minValueSecondLap + 1){
                minValueSecondLap++;
            }

            if(nums[i] == maxValueSecondLap - 1){
                minValueSecondLap--;
            }
        }

        if(maxValueSecondLap - minValueSecondLap > 1){
            return (minValueSecondLap + 1);
        }

        return maxValueSecondLap + 1;
    }
}
