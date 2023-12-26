using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        int min = Int32.MaxValue;
        int index =0;
        List<int> temp = new List<int>(arr);
        if(temp.Count>1)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]<=min)
                {
                    index =i;
                    min = arr[i];
                }
            }
            temp.RemoveAt(index);
        }
        else
        {
            temp.Clear();
            temp.Add(-1);
        }
        int[] answer = temp.ToArray();
        return answer;
    }
}