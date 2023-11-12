using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {

        
        List <int> stk = new List<int>();
        int num =0;
        while(num <arr.Length)
        {
            if(stk.Count<1)
            {
                stk.Add(arr[num]);
                num++;
            }
            else if(stk.Count>0)
            {
                if(stk[stk.Count-1] ==arr[num])
                {
                    stk.RemoveAt(stk.Count-1);
                    num++;
                }
                else if(stk[stk.Count-1] !=arr[num])
                {
                    stk.Add(arr[num]);
                    num++;
                }
            }
        }
        if(stk.Count<1)
        {
            stk.Add(-1);
        }
        int[] answer = stk.ToArray();
        return answer;
    }
}