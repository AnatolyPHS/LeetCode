using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{
    private void Start()
    {
        int[] height = new int[] {2,0,2};
        Debug.Log(Trap(height));
    }
    
        public int Trap(int[] height) {
            int highestPoint = 0;
            Dictionary<int, bool[]> levelBlocks = new Dictionary<int, bool[]>();
    
            for (int i = 0; i < height.Length; i++){
                if (height[i] > highestPoint){
                    highestPoint = height[i];
                }
    
                for(int j = 0; j < height[i] + 1; j++){
                    if (levelBlocks.ContainsKey(j) == false){
                        levelBlocks[j] = new bool[height.Length];
                    }
    
                    levelBlocks[j][i] = height[i] > j;
                }
            }
    
                    
            int finalCount = 0;
    
            for  (int i = 0; i < highestPoint; i++){
                bool[] level = levelBlocks[i];
                int openPosition = -1;
                for (int j = 0; j < level.Length; j++){
                    if (level[j] == true){
                        if (openPosition < 0 || i - openPosition == 1){
                            openPosition = j;
                            continue;
                        }
    
                        finalCount += (j - openPosition - 1);
                        openPosition = j;
                    }
                }
            }
    
            return finalCount;
        }
}
