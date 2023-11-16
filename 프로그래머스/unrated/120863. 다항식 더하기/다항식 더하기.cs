using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        string[] temp = polynomial.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string answertemp = "";
        int xSum = 0;
        int sum = 0;
        // temp의 배열값들을 다시 string answertemp로 합침
        foreach (string s in temp)
        {
            answertemp += s;
        }
        // 합친 answertemp를 "+"로 나누어서 temp3로 저장
        string[] temp3 = answertemp.Split("+");
        // temp3의 배열값들을 출력
        foreach (string s in temp3)
        {
            Console.Write(s);
            Console.Write($" ");
        }
        Console.WriteLine();
        // temp3의 배열을 하나씩 조사하면서 
        foreach (string a in temp3)
        {
            // x가 포함되어있다면 
            if (a.Contains("x"))
            {
                // x를 a에서 제거하고 남은수를 xSum에 더하는데
                // 만약 x를 제거하고 ""만 남았다면 xSum 에 1만 더한다.
                string temp4=a.Replace("x", "");
                if(temp4 == "")
                {
                    xSum += 1;
                }
                else
                {
                    xSum+=int.Parse(temp4);
                }
                Console.WriteLine("$xSum : {0}", xSum);
            }
            else // x 가 포함되어 있지 않다면 
            {
                sum += int.Parse(a);
                Console.WriteLine("$sum : {0}", sum);
            }
        }
        if (sum ==0)
        {
             if (xSum != 1)
            {
                answer += xSum.ToString();
                answer += "x";
            }
            else
            {
                answer += "x";
            }
        }
        
        if (xSum == 0)
        {
            answer += sum.ToString();
        }
        
        if(xSum!=0 && sum!=0)
        {
            if (xSum != 1)
            {
            answer += xSum.ToString();
            answer += "x + ";
            answer += sum.ToString();
            }
            else
            {
                answer += "x + ";
            answer += sum.ToString();
            }
        }
        
        Console.WriteLine(answer);
        return answer;
    }
}