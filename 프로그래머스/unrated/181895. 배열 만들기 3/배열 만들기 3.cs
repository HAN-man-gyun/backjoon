using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[,] intervals) {
        List <int> temp = new List <int>();
        for(int i=intervals[0,0]; i <= intervals[0,1]; i++)
        {
             temp.Add(arr[i]);
        }
         for(int i=intervals[1,0]; i <= intervals[1,1]; i++)
        {
             temp.Add(arr[i]);
        }
        int [] answer  = temp.ToArray();
        
        return answer;
    }
}