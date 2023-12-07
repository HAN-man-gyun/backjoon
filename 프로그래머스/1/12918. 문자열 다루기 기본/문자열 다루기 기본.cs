public class Solution {
    public bool solution(string s) {
        bool answer = true;
        bool temp1 =false;
        foreach(char a in s)
        {
            if(a>=48 && a<=57)
            {
                temp1 = true;
            }
            else
            {
                temp1 = false;
                break;
            }
        }
        if((s.Length ==4 || s.Length==6)&& temp1==true)
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        return answer;
    }
}