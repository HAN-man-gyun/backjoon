using System;

public class Solution {
    public int solution(int[] num_list) {
        int answer = 0;
        int count =0;
        for(int i=0; i<num_list.Length; i++)
        {
            while(num_list[i]!=1)
            {
                if(num_list[i] %2 ==0)
                {
                    num_list[i]=num_list[i]/2;
                    count++;
                }
                else
                {
                    num_list[i]=(num_list[i]-1)/2;
                    count++;
                }
            }
        }
        answer = count;
        return answer;
    }
}