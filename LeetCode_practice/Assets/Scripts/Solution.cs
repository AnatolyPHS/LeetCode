using UnityEngine;

public class Solution : MonoBehaviour
{
    private void Start()
    {
        /*int[] nums = new int[] { 100000, 3, 4000, 2, 15, 1, 99999 };*/
        /*int[] nums = new int[] { 1,2,0 };*/
        /*int[] nums = new int[] { 3,4,-1,1};*/
        int[] nums = new int[] { 0,-1,3,1};
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

        int sortedIndex = 0;
        while (sortedIndex < nums.Length)
        {
            int index = nums[sortedIndex] - 1;
            if (nums[sortedIndex] > 0 && nums[sortedIndex] < nums.Length && nums[sortedIndex] != nums[index])
            {
                (nums[sortedIndex], nums[index]) = (nums[index], nums[sortedIndex]);
                continue;
            }
            
            sortedIndex++;
        }
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] - nums[i - 1] != 1)
            {
                return nums[i -1] + 1;
            }
        }

        return maxValue + 1;
    }
}
