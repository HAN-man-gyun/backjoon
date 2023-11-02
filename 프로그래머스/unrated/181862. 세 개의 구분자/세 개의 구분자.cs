using System;

public class Solution {
    public string[] solution(string myStr) {
        char[] temp = new char[myStr.Length];
        bool isbool =false;
        for(int i=0; i<myStr.Length ; i++)
        {
            temp[i] = myStr[i];
        }
        for(int i=0; i<temp.Length; i++)
        {
            if(temp[i] =='a' ||temp[i] =='b'||temp[i] =='c')
            {
                temp[i] =' ';
            }
            else 
            {
                isbool = true;
            }
        }
        string[] answer = new string[]{};
        string temp2 =new string (temp);
        if(isbool == true)
        {
        answer=temp2.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        }
        else
        {
        answer = new string[1] {"EMPTY"};
        }
        return answer;
    }
}