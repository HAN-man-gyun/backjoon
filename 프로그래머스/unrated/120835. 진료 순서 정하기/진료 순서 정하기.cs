using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        int[] ex = new int[emergency.Length];
        Array.Copy(emergency, ex, emergency.Length);
        Array.Sort(ex);
        Array.Reverse(ex);
        int index = 0;
        for(int i = 0; i< emergency.Length; i++)
        {
            for(int j = 0; j<ex.Length; j++)
            {
                if(emergency[i] == ex[j])
                {
                    answer[index] = j+1; 
                    index++;
                }
            }
        }
        
        return answer;
    }
}