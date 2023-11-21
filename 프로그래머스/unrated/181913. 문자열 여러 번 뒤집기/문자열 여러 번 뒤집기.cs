using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string my_string, int[,] queries) {
            List<char> temp = new List<char>(my_string.ToCharArray());
            for (int i = 0; i < queries.GetLength(0); i++)
            {
                int startIdx = queries[i, 0];
                int endIdx = queries[i, 1];
                List<char> temp2 = temp.GetRange(startIdx, endIdx-startIdx+1);
                temp2.Reverse();
                temp.RemoveRange(startIdx, endIdx - startIdx + 1);
                temp.InsertRange(startIdx, temp2);
            } 
         string answer = "";
 foreach (char a in temp)
 {
     answer += a;
 }
            return answer;
    }
}