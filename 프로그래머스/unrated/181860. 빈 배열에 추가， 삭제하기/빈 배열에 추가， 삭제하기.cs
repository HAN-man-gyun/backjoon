using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, bool[] flag) {
        List<int> intArray = new List<int>();
        for(int i=0; i<flag.Length; i++)
        {
            if(flag[i] == true)
            {
                for(int j=0; j<arr[i]*2; j++)
                {
                    intArray.Add(arr[i]);
                }
            }
            else
            {
                for(int j =0; j<arr[i]; j++)
                {
                intArray.RemoveAt(intArray.Count - 1);
                }
            }
        }
        int [] answer = intArray.ToArray();
        return answer;
    }
}