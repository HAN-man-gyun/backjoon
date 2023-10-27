using System;

public class Solution {
    public int[] solution(int[] arr) {
        int leng =0;
        foreach(int a in arr)
        {
            leng +=a;
        }
        int[] answer = new int[leng];
        int index =0;
        foreach(int a in arr)
        {
            for(int i=0; i<a; i++)
            {
                answer [index] = a;
                index++;
            }
        }
        return answer;
    }
}