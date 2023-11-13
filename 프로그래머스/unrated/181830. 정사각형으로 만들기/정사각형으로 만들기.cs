using System;

public class Solution {
    public int[,] solution(int[,] arr) {
        
        int row = arr.GetLength(0);
        int column = arr.GetLength(1);
        
        if(row > column)
        {
            column =row;   
        }
        else if(row < column)
        {
            row = column;
        }
        
        int[,] answer = new int[row,column];
        for(int i=0; i<answer.GetLength(0); i++)
        {
            for(int j=0; j<answer.GetLength(1); j++)
            {
                answer[i,j] = 0;
            }
        }
        for(int i=0; i<arr.GetLength(0); i++)
        {
            for(int j=0; j<arr.GetLength(1); j++)
            {
                answer[i,j] = arr[i,j];
            }
        }
        
        
        return answer;
    }
}