using System;
public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int tempSum =0;
        string temp = x.ToString();
        foreach(char a in temp)
        {
             tempSum+=a-48;
            Console.Write(a-48);
        }
        answer = (x % tempSum ==0) ? true : false;
        
        return answer;
    }
}