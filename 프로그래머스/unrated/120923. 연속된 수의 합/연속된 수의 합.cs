using System;

public class Solution {
    public int[] solution(int num, int total) {
               int[] answer = new int[num];
int index = 0;
int tempSum = 0;
int tempIndex = 0;
if (num != 1)
{
    if (total != 0)
    {
        for (int i = -total; i <= total; i++)
        {
            while (index < num)
            {
                tempSum += i + index;
                index++;
            }
            if (tempSum == total)
            {
                tempIndex = i;
                break;
            }
            index = 0;
            tempSum = 0;
        }
    }
    else
    {
        for(int i = -((num-1)/2);i<=((num-1)/2);i++)
        {
            while(index <num)
            {
                tempSum += i + index;
                index++;
            }
            if (tempSum == total)
            {
                tempIndex = i;
                break;
            }
            index = 0;
            tempSum = 0;
        }
    }
    index = 0;
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = tempIndex + index;
        index++;
    }
}
else
{
    answer[0] = total;
}
return answer;
    }
}