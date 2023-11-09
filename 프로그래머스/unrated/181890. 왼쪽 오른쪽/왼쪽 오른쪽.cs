using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] str_list) {
        int lIndex = -1;
        int rIndex = -1;
        List<string> temp = new List<string>();
        for(int i=0; i<str_list.Length; i++)
        {
            if(str_list[i] =="l")
            {
                lIndex = i;
                break;
            }
            else if(str_list[i] =="r")
            {
                rIndex = i;
                break;
            }
        }
        if(lIndex !=-1)
        {
            for(int i=0; i<lIndex; i++)
            {
                temp.Add(str_list[i]);
            }
        }
        if(rIndex !=-1)
        {
             for(int i=rIndex+1; i<str_list.Length; i++)
            {
                temp.Add(str_list[i]);
            }
        }
        string[] answer = temp.ToArray();
        
        return answer;
    }
}