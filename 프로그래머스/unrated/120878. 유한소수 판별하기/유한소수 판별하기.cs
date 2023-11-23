using System;

public class Solution {
    public int solution(int a, int b) {
                int answer = 1;
        int min = a > b ? b : a;
        int max = 0;
        // 최대공약수 찾는과정
        for (int i = 1; i <= min; i++)
        {
            if (a % i == 0 && b % i == 0 && max < i)
            {
                max = i;
            }
        }
        // 최대공약수가 존재한다면 a와 b를 최대공약수로 나눔
        if (max != 0)
        {
            a = a / max;
            b = b / max;
        }

        // 기약분수상태인 a와 b에서 b의 소인수가 오직 2와 5밖에없는지 확인하는법
        while(b%2==0)
        {
            b = b/2;
        }
        while(b%5==0)
        {
            b = b/5;
        }
        if(b ==1)
        {
            answer =1;
        }
        else
        {
            answer =2;
        }
        return answer;
    }
}