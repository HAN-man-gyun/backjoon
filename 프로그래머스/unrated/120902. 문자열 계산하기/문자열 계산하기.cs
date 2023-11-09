using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string temp2 = my_string.Replace(" ", "");
        List<string> temp3 = new List<string>();
        List<char> temp4 = new List<char>();
        for(int i=0; i<temp2.Length;i++)
        {
            if(temp2[i] =='+' || temp2[i]=='-')
            {
                temp3.Add(new string (temp4.ToArray()));
                temp4.Clear();
                temp4.Add(temp2[i]);
            }
            else
            {
                temp4.Add(temp2[i]);
            }
        }
        temp3.Add(new string (temp4.ToArray()));
        foreach(string a in temp3)
        {
            answer += int.Parse(a);
        }
        return answer;
    }
}