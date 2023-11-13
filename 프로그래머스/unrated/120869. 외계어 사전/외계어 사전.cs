using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string[] spell, string[] dic) {
         int answer = 2;
        int[] temp = new int[spell.Length];
        List<char[]> temp2 = new List<char[]>();
        foreach (string a in spell)
        {
            char[] Array = a.ToCharArray();
            temp2.Add(Array);
        }
        foreach (string a in dic)
        {
            List<char> temp3 = new List<char>(a.ToCharArray());
            int count = 0;
            for (int j = 0; j < temp3.Count; j++)
            {
                for (int i = 0; i < temp2.Count; i++)
                {
                    if (temp3[j] == temp2[i][0])
                    {
                        temp[i]++;
                    }
                }
            }
            foreach(int c in temp)
            {
                if(c ==1)
                {
                    count++;
                }
            }
            if(count ==spell.Length)
            {
                answer = 1;
                break;
            }
            else
            {
                for (int i=0; i<temp.Length; i++)
                {

                    temp[i] = 0;

                }
            }
        }
        return answer;
    }
}