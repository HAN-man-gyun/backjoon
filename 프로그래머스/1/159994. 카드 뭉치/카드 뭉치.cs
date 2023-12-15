using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
    string answer = "";
        List<string> temp1 = new List<string>();
        List<string> temp2 = new List<string>();
        bool isInTemp1  =false;
        bool isInTemp2  =false;
        foreach (string card in cards1)
        {
            temp1.Add(card);
        }
        foreach (string card in cards2)
        {
            temp2.Add(card);
        }
        for(int i=0; i<goal.Length; i++)
        {
            if (temp1.Count>0)
            {
                if(temp1[0] == goal[i])
                {
                    isInTemp1 = true;
                    temp1.RemoveAt(0);
                }
            }
            if (temp2.Count > 0)
            {
                if ((temp2[0] == goal[i]))
                {
                    isInTemp2 = true;
                    temp2.RemoveAt(0);
                }
            }
            if(isInTemp1 == false && isInTemp2 == false)
            {
                answer += "No";
                break;
            }
            isInTemp1 = false;
            isInTemp2 = false;
        }
        if(answer !="No")
        {
            answer += "Yes";
        }
        return answer;
    }
}