using System;

public class Solution {
    public string solution(string myString) {
        string answer = "";
        int index =0;
        for(int a = 0; a < myString.Length; a++)
        {
            if(myString[a] <'l')
            {
                answer = answer + "l";
            }
            else
            {
                answer = answer + myString[a];
            }
        }
        return answer;
    }
}