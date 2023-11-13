using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] picture, int k) {
        int row = picture.Length*k;
        int index =0;
        string[] answer = new string[row];
        foreach (string a in picture)
        {
            for(int j=0; j<k; j++)
            {
            List<char> temp = new List<char>(a.ToCharArray());
            List<char> temp2 = new List<char>();
            foreach(char b in temp)
            {
                for(int i=0; i<k; i++)
                {
                    temp2.Add(b);
                }
            }
            answer [index] += new string(temp2.ToArray());
            index++;
            }
        }
        return answer;
    }
}