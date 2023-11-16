using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int l, int r) {
        
        List<int> temp = new List<int>();
        for(int i =l ; i<=r; i++)
        {
            string temp2=i.ToString();
            bool isNot = false;
            foreach(char a in temp2)
            {
                if(!(a=='5'||a=='0'))
                {
                    isNot = true;
                }
            }
            if(isNot == false)
            {
                temp.Add(i);
            }
        }
        int[] answer = temp.ToArray();
        if(answer.Length<1)
        {
            answer = new int[1] {-1};
        }
        return answer;
    }
}