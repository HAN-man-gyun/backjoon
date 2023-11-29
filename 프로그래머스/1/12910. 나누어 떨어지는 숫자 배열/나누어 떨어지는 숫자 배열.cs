using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int divisor) {
        
        List<int>temp =new List<int>();
        foreach(int a in arr)
        {
            if(a%divisor ==0)
            {
                temp.Add(a);
            }
        }
        if(temp.Count <1)
        {
            temp.Add(-1);
        }
        int[] answer = temp.ToArray();
        Array.Sort(answer);
        
        return answer;
    }
}