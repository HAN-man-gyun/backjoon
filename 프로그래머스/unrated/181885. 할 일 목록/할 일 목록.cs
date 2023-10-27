using System;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished) {
        int index =0;
         foreach(bool a in finished)
        {
            if(a == false)
            {
                 index++;
            }
        }
        
        string[] answer = new string[index];
        index = 0;
        for(int i =0; i< finished.Length; i++)
        {
            if(finished[i] == false)
            {
                answer[index] =todo_list[i];
                index += 1;
            }
        }
        
        return answer;
    }
}