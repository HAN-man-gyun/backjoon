using System;

public class Solution {
    public int solution(int a, int d, bool[] included) {
        int answer = 0;
        int[] sum = new int [included.Length];
        sum[0] = a;
        for(int i=1; i<included.Length;i++)
        {
            a +=d; 
            sum[i] = a;
        }
        for(int i=0; i<included.Length; i++)
        {
            if(included[i] == true)
            {
                answer += sum[i];
            }
        }
        return answer;
    }
}