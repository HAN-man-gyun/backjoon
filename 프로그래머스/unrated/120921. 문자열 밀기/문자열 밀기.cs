using System;
using System.Collections.Generic;
public class Solution {
    public int solution(string A, string B) {
        int answer = 0;
        int count = 0;
        bool isOK = false;
        List<char> temp = new List<char>(A.ToCharArray());
        for (int i = 0; i < temp.Count; i++)
        {
            string temp2 = "";
            foreach (char b in temp)
            {
                temp2 += b;
            }
            if (temp2.Equals (B))
            {
                isOK = true;
                break;
            }
            char a = temp[temp.Count - 1];
            temp.Insert(0, a);
            temp.RemoveAt(temp.Count - 1);
            count++;
        }
        if (isOK == true)
        {
            answer = count;
        }
        else
        {
            answer = -1;
        }

        return answer;
    }
}