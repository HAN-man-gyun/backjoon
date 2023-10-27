using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[queries.GetLength(0)];
        int index =0;
        int answerIndex =0;
        int min =1000001;
        for(int i=0; i<queries.GetLength(0); i++)
        {
            for(int j=queries[i,0]; j<= queries[i,1];j++)
            {
                if(arr[j] > queries[i,2])
                {
                    if(min>arr[j])
                    {
                        min = arr[j];
                    }
                }
            }
            if(min == 1000001)
            {
                answer[answerIndex] =-1;
            }
            else
            {
                answer[answerIndex] =min;
            }
            answerIndex ++;
            min = 1000001;
        }
        return answer;
    }
}