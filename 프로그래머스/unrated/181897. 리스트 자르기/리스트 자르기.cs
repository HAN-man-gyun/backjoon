using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n, int[] slicer, int[] num_list) {
        List<int> temp = new List<int>();
        switch(n)
        {
            case 1 :
                for(int i=0; i<=slicer[1]; i++)
                {
                    temp.Add(num_list[i]);
                }
                break;
            case 2 :
                for(int i=slicer[0]; i<num_list.Length; i++)
                {
                    temp.Add(num_list[i]);
                }
                break;
            case 3 :
                for(int i=slicer[0]; i<=slicer[1]; i++)
                {
                    temp.Add(num_list[i]);
                }
                break;
            case 4 :
                int a =slicer[2];
                for(int i=slicer[0]; i<=slicer[1]; i++)
                {
                    if(a ==slicer[2])
                    {
                        a=1;
                        temp.Add(num_list[i]);
                    }
                    else
                    {
                        a++;
                    }
                }
                break;
        }
        int[] answer = temp.ToArray();
        return answer;
    }
}