using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        // sides[0] 과 sides[1] 중 큰걸 구하기
        int compare = sides[0] <sides[1] ? sides[1]: sides[0];
        int mincompare = sides[0] < sides[1] ? sides[0]: sides[1];
        int sum = sides[0] + sides[1];
        // a가 제일 큰변일경우
        for(int i=compare; i<sum; i++)
        {
            answer++;
        }
        // a가 제일 큰변이 아닐경우
        // a +mincompare < compare
        // a <compare-mincompare
        for(int i= 1; i<compare; i++)
        {
            if(i +mincompare >compare)
            {
                answer++;
            }
        }
        
        return answer;
    }
}