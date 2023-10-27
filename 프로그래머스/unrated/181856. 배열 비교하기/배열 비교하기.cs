using System;

public class Solution {
    public int solution(int[] arr1, int[] arr2) {
        int answer = 0;
        int arr1Sum =0;
        int arr2Sum =0;
        if(arr1.Length > arr2.Length)
        {
            answer =1;
        }
        else if(arr1.Length < arr2.Length)
        {
            answer =-1;
        }
        else
        {
            foreach(int a in arr1)
            {
                arr1Sum += a;
            }
            foreach(int a in arr2)
            {
                arr2Sum += a;
            }
            if(arr1Sum > arr2Sum)
            {
                answer =1;
            }
            else if (arr1Sum<arr2Sum)
            {
                answer =-1;
            }
            else 
            {
                answer =0;
            }
        }
        return answer;
    }
}