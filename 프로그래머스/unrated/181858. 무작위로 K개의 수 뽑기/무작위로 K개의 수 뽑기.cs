using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr, int k) {
        
        List<int> temp = new List<int>();
        int arrIdx =0;
        while(temp.Count <k)
        {
            bool isExist = false;
            foreach(int a in temp)
            {
                if(a == arr[arrIdx])
                {
                    isExist = true;
                }
            }
            if(isExist == false)
            {
                temp.Add(arr[arrIdx]);
            }
            
            arrIdx++;
            if(arrIdx>arr.Length-1)
            {
                break;
            }
            
        }
        if (arrIdx > arr.Length - 1)
        {
            for(int i=temp.Count; i<k;i++)
            {
                temp.Add(-1);
            }
        }
        int[] answer = temp.ToArray();
        return answer;
    }
}