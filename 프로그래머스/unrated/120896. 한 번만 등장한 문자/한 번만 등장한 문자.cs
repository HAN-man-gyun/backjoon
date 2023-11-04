using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string temp2 = "abcdefghijklmnopqrstuvwxyz";
        int [] temp = new int[26];
        for(int j=0; j<s.Length; j++)
        {
            for(int i=0; i<temp2.Length; i++)
            {
                if(s[j] == temp2[i])
                {
                    temp[i] +=1;
                }
            }
        }
        for(int i=0; i<temp.Length; i++)
        {
            if(temp[i] ==1)
            {
                answer+=temp2[i]; 
            }
        }
        return answer;
    }
}