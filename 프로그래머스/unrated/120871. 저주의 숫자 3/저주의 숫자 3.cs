using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n) {
         int answer = 1;
 List <int> temp = new List<int>();
 while(temp.Count<=n)
 {
     if((answer%3==0)||(answer.ToString().Contains("3")))
     {
     }
     else { temp.Add(answer);
     }
     if(temp.Count==n)
     {
         break;
     }
     answer++;
 }
 return answer;
    }
}