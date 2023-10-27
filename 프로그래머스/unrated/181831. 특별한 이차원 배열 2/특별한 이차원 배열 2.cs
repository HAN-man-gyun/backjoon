using System;

public class Solution {
    public int solution(int[,] arr) {
        int answer = 0;
        bool isbreak = false;
        for(int i=0; i<arr.GetLength(0); i++)
        {
            for(int j=0; j<arr.GetLength(1); j++)
            {
                if(arr[i,j] == arr[j,i])
                {
                    answer =1;
                }
                else
                {
                    answer =0;
                    isbreak =true;
                    break;
                }
            }
            if(isbreak)
            {
                break;
            }
        }
        
        return answer;
    }
}