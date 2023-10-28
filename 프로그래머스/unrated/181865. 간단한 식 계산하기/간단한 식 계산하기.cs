using System;

public class Solution {
    public int solution(string binomial) {
        char temp ='a';
        int answer = 0;
        string[] temp2 = new string[2];
        foreach(char a in binomial)
        {
            if ((int)a == 42 || (int)a == 43 || (int)a == 45)
            {
                 temp=a;
                 temp2=binomial.Split(a);
            }
        }
        switch((int)temp)
        {
            case 42:
                answer=(int.Parse(temp2[0])) * (int.Parse(temp2[1]));
                break;
            case 43:
                answer=(int.Parse(temp2[0])) + (int.Parse(temp2[1]));
                break;
            case 45:
                answer =(int.Parse(temp2[0])) - (int.Parse(temp2[1]));
                break;
        }
        
        
        return answer;
    }
}