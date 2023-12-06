using System.Collections.Generic;
public class Solution {
    public string solution(string s) {
        string answer = "";
        List<char> temp1 = new List<char>();
        List<char> temp2 = new List<char>();
        foreach(char a in s)
        {
            if((a >=65 && a<=90))
            {
                temp1.Add(a);
            }
            else
            {
                temp2.Add(a);
            }
        }
        temp1.Sort();
        temp1.Reverse();
        temp2.Sort();
        temp2.Reverse();
         foreach(char a in temp2)
        {
            answer+=a;
        }
        foreach(char a in temp1)
        {
            answer+=a;
        }
        
        
        
        
        
        return answer;
    }
}