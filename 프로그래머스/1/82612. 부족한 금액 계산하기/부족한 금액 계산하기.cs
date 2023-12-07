using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long sumPrice=0;
        long answer=0;
        for(int i=1; i<=count; i++)
        {
            sumPrice += price *i;
        }
        if(sumPrice>money)
        {
            answer=sumPrice-money;
        }
        else
        {
            answer =0;
        }
        return answer;
    }
}