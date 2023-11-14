using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        string answer = "";
        bool idCorrect = false;
        bool psCorrect = false;
        
        for(int i=0; i<db.GetLength(0); i++)
        {
            if(db[i,0] == id_pw[0])
            {
                idCorrect = true;
            }
            if(db[i,1] == id_pw[1])
            {
                psCorrect = true;
            }
            if(idCorrect ==true && psCorrect == true)
            {
                answer += "login";
                break;
            }
            else if(idCorrect ==true && psCorrect == false)
            {
                answer += "wrong pw";
            }
            idCorrect = false;
            psCorrect = false;
        }
        if(answer.Length<1)
        {
            answer +="fail";
        }
        return answer;
    }
}