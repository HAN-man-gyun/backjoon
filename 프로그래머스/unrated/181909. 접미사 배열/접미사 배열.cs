using System;
public class Solution {
    public string[] solution(string my_string) {
        string[] temp = new string[my_string.Length];
        int index =0;
        for(int i=0; i< my_string.Length; i++)
        {
            for(int j=i; j<my_string.Length; j++)
            {
                temp[index] += my_string[j];
            }
            index++;
        }
        Array.Sort(temp);
        string[] answer = temp;
        return answer;
    }
}