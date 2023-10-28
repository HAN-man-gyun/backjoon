using System;

public class Solution {
    public string[] solution(string myString) {
        string[] temp = myString.Split("x",StringSplitOptions.RemoveEmptyEntries);
        
        Array.Sort(temp);
        string[] answer = temp;
        return answer;
    }
}