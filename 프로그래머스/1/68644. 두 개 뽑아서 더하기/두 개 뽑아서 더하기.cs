using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] numbers) {
        
        List<int> temp = new List<int>();
        for(int i=0; i<numbers.Length-1; i++)
        {
            for(int j=i+1; j<numbers.Length; j++)
            {
                bool isInList =false;
                foreach(int a in temp)
                {
                    if(a == numbers[i]+numbers[j])
                    {
                        isInList = true;
                    }
                }
                if(isInList == false)
                {
                    temp.Add(numbers[i]+numbers[j]);
                }
            }
        }
        temp.Sort();
        int[] answer=temp.ToArray();
        return answer;
    }
}