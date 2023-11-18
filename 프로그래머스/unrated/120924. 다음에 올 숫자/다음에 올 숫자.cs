using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        int two_one = common[2] - common[1];
        int one_zero = common[1] - common[0];
        int twoOne =0;
        if(two_one == one_zero)
        {
            answer=common[common.Length-1]+two_one;
        }
        else
        {
            if(common[0] == 0)
            {
                answer =0;
            }
            else
            {
                twoOne = common[2]/common[1];
                answer = common[common.Length-1]*twoOne;
            }
            
        }
        
        return answer;
    }
}