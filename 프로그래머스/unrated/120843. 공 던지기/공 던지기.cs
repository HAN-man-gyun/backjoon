using System;

public class Solution {
    public int solution(int[] numbers, int k) {
        int answer = 0;
        int count =0;
        int end =1;
        bool isbreak =false;
        while(true)
        {
            for(int i=0; i<numbers.Length; i++)
            {
                end++;
                if(end ==2)
                {
                    count++;
                    end =0;
                    if(count ==k)
                    {
                        answer=i+1;
                        isbreak =true;
                        break;
                    }
                }
            }
            if(isbreak == true)
            {
                break;
            }
        }
        return answer;
    }
}