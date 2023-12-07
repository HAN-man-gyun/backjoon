using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int n) {
      int answer = 0;
 int i = 0;
 List<int> temp1 = new List<int>();
 while (n >= 3)
 {
     temp1.Add(n % 3);
     n /= 3;
 }
 temp1.Add(n);
 temp1.Reverse();
 foreach (int a in temp1)
 {
     int temp2 = 0;
     temp2 = (int)(Math.Pow(3, i));
     i++;
     answer += a * temp2;
 }
 return answer;
    }
}