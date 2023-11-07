using System;

public class Solution {
    public int solution(string[] strArr) {
        int answer = 0;
        int [] eleLength = new int[31];
        foreach (string a in strArr)
        {
            eleLength[a.Length]++;
        }
        int max =0;
        int maxIdx =-1;
        for (int i =0; i< eleLength.Length;i++)
        {
            if(max < eleLength[i])
            {
                max = eleLength[i];
                maxIdx = i; 
            }
        }
        foreach (string a in strArr)
        {
            if(a.Length == maxIdx)
            {
                answer++;
            }
        }
        return answer;
    }
}