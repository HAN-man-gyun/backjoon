using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        int firIdx =-1;
        int secIdx =-1;
        for(int i=0; i<arr.Length; i++)
        {
            if(firIdx ==-1)
            {
                if(arr[i] ==2)
                {
                    firIdx =i;
                }
            }
            else if (firIdx != -1)
            {
                 if(arr[i] ==2)
                {
                    secIdx =i;
                }
            }
        }
        List<int> temp = new List<int>();
        if(firIdx == -1)
        {
            temp.Add(-1);
        }
        else if(firIdx !=-1 && secIdx ==-1)
        {
            temp.Add(arr[firIdx]);
        }
        else
        {
            for(int i=firIdx; i<=secIdx; i++)
            {
                temp.Add(arr[i]);
            }
        }
        int[] answer = temp.ToArray();
        
        return answer;
    }
}