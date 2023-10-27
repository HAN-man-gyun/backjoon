using System;

public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int[] answer = new int[arr.Length];
        
            for(int j=0; j<queries.GetLength(0) ; j++)
            {
                for(int k = queries[j,0]; k<=queries[j,1]; k++)
                {
                    if(k %queries[j,2] == 0)
                    {
                        answer[k] +=1;
                    }
                }
            }
        for(int i=0; i<arr.Length;i++)
        {
            answer[i]+=arr[i];
        }
        return answer;
    }
}