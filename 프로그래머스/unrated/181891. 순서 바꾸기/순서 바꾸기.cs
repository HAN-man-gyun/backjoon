using System;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        int[] answer = new int[num_list.Length];
        int index =0;
        for(int i=n; i<num_list.Length; i++)
        {
            answer[index] = num_list[i];
            index++;
        }
        for(int i=0; i<n; i++)
        {
            answer[index] = num_list[i];
            index++;
        }
        
        
        return answer;
    }
}