using System;

public class Solution {
    public int solution(int[] array) {
         int answer = 0;
        int[] temp = new int[1001];
        int max = 0;
        int maxIndex = 0;
        foreach (int a in array)
        {
            //Console.WriteLine(a);
            temp[a]++;
        }
        //Console.WriteLine("끝");
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i]>max)
            {
                answer = i;
                maxIndex = i;
                max = temp[i];
            }
        }
        for (int i=0; i< temp.Length; i++)
        {
            if (i==maxIndex)
            {
            }
            else 
            {
                if (temp[i] == temp[maxIndex])
                {
                    answer = -1;
                }
            }
        }
        //Console.WriteLine(answer);
        return answer;
    }
}