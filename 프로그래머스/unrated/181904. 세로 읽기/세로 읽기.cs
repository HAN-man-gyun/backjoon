using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        
        string[] temp = new string[m];
        for(int i =0; i<my_string.Length; i++)
        {
            temp[i%m] += my_string[i];
        }
        string answer = temp[c-1];
        return answer;
    }
}