using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
 int answer = 0;
 Array.Sort(score);

 int n = score.Length-1;
 while (n-m+1>=0)
 {

     
     answer += score[n - m+1] * m;

     n = n - m;

 }
return answer;
    }
}