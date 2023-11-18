using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] quiz) {
        List<string> one = new List<string>();
        for(int i=0; i<quiz.Length; i++)
        {
        string[] temp = quiz[i].Split(" ");
        int sum =0;
        switch(temp[1])
        {
            case "+":
                sum = int.Parse(temp[0]) + int.Parse(temp[2]);
                break;
            case "-":
                sum = int.Parse(temp[0]) - int.Parse(temp[2]);
                break;
        }
        if(sum == int.Parse(temp[4]))
        {
            one.Add("O");
        }
        else
        {
            one.Add("X");
        }
        
    }
        string[] answer = one.ToArray();
        return answer;
    }
}