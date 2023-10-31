using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string temp = "";
        foreach( char a in my_string)
        {
            if(a >=48 && a<=57)
            {
                temp += a;
            }
            else
            {
                temp +='x';
            }
        }
        string[] temp2 =temp.Split( "x",StringSplitOptions.RemoveEmptyEntries);
        foreach(string a in temp2)
        {
            answer +=int.Parse(a);
        }
        return answer;
    }
}