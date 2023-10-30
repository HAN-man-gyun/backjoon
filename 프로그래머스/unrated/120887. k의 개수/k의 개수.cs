using System;

public class Solution {
    public int solution(int i, int j, int k) {
        string temp ="";
        int answer =0;
        for (int a =i; a<=j; a++)
        {
            temp = a.ToString();
            char [] array = temp.ToCharArray();
            foreach(char b in array)
            {
                if(b-48 == k)
                {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}