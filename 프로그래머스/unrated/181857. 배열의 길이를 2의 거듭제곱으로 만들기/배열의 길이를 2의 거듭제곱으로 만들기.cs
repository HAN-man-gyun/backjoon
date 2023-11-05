using System;

public class Solution {
    public int[] solution(int[] arr) {
        
        int i =1;
        if(arr.Length==1)
        {
            i=1;
        }
        else
        {
            while(i<arr.Length)
            {
                i=i*2;
            }
        }
        int[] answer = new int[i];
        for(int j=0; j<=arr.Length-1;j++)
        {                
            answer[j] = arr[j];
        }
        for(int j=arr.Length; j<=i-1; j++)
        {
            answer[j] = 0;
        }

      
        
        return answer;
    }
}