using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        for (int i = 0; i <= t.Length - p.Length; i++)
        {
            string s = "";
            for (int j = i; j < (int)i + p.Length; j++)
            {
                s += t[j];
            }
            if (long.Parse(s) <= long.Parse(p))
            {
                answer++;
            }
        }
        return answer;
    }
}