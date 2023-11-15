using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        int answer = 0;
List<int> temp = new List<int>(rank);
List<int> tempAn = new List<int>();
int min = 200;
int minIndex = 200;

while (true)
{
    for (int i = 0; i < temp.Count; i++)
    {   //temp의 모든 배열을 돌면서 가장작은 값을서치
        if (temp[i] < min)
        {
            min = temp[i];  //가장작은값을 담음
            minIndex = i;   //가장작은값의 인덱스를 담음
        }
    }
    if (attendance[minIndex] != false)
    {   //가장 작은값을가진 학생이 만약 false가 아니라면
        tempAn.Add(minIndex); //tempAn에 가장작은값을담음
    }
    foreach (int i in tempAn)
    {
        Console.Write(i);
    }
    Console.WriteLine();
    
    temp[minIndex] =200; //그리고 가장작은갑을 200으로 바꿔버림
    minIndex = 200; //가장작은값의 인덱스를 200으로 초기화
    min = 200;
    if (tempAn.Count == 3)
    {   //tempAn에 3번 Add가 되서 Count가 3개가 되면 반복문을 종료
        break;
    }
}
answer += tempAn[0] * 10000 + tempAn[1] * 100 + tempAn[2];
Console.WriteLine(answer);
return answer;
    }
}