using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        
        List<int> temp = new List<int>();
        int i=0;
        while(i<arr.Length)
        {
            if(temp.Count ==0)
            {
                temp.Add(arr[i]);
                i++;
            }
            if(temp.Count > 0)
            {
                if(temp[temp.Count-1]<arr[i])
                {
                    temp.Add(arr[i]);
                    i++;
                }
                else if(temp[temp.Count-1] >=arr[i])
                {
                    temp.RemoveAt(temp.Count-1);
                }
            }
        }
        int[] stk = temp.ToArray();
        return stk;
    }
}