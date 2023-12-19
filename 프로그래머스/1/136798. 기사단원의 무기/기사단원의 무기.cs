using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        List<int> temp = new List<int>();
        for (int i = 1; i <= number; i++)
        {
            int count = 0;
            for (int j = 1; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    if(i/j ==j)
                    {
                        count++;
                    }
                    else
                    {
                        count+=2;
                    }
                }
            }
            temp.Add(count);
        }
        for (int a = 0; a < temp.Count; a++)
        {
            if (limit < temp[a])
            {
                temp[a] = power;
            }
            answer += temp[a];
        }
        return answer;
    }
}