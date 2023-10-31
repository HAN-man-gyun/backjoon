using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 1000;
        int maxMin =1000;
        int lowMin =1000;
        int maxIndex =0;
        int lowIndex =0;
        for(int i =0; i< array.Length; i++)
        {
            if(array[i]>n)
            {
                if(Math.Abs(n-array[i])<maxMin)
                {
                    maxMin = Math.Abs(n-array[i]);
                    maxIndex=i;
                }
            }
            else if(array[i]<n)
            {
                 if(Math.Abs(array[i]-n)<lowMin)
                {
                    lowMin = Math.Abs(array[i]-n);
                    lowIndex=i;
                }
            }
            else if(array[i] ==n)
            {
                answer = array[i];
                return answer;
            }
        }
        if(maxMin==lowMin)
        {
            answer=array[lowIndex];
        }
        else if(maxMin >lowMin)
        {
            answer =array[lowIndex];
        }
        else if(lowMin>maxMin)
        {
            answer =array[maxIndex];
        }
        return answer;
    }
}