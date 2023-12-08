public class Solution {
    public string solution(string s) {
       string answer = "";
        string[] temp = s.Split(" ");

        for (int j = 0; j < temp.Length; j++)
        {
            char[] temp2 = temp[j].ToCharArray();

            for (int i = 0; i < temp2.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    if ((int)temp2[i] >= 65 && (int)temp2[i] <= 90)
                    {
                        temp2[i] = (char)((int)temp2[i] + 32);
                    }
                }
                else if((i+1) %2 !=0)
                {

                    if ((int)temp2[i] >= 97 && (int)temp2[i] <= 122)
                    {
                        temp2[i] = (char)((int)temp2[i] - 32);
                    }
                }
                answer += temp2[i];
            }
            if (j < temp.Length-1)
            {
                answer += " ";
            }
   
        }

        return answer;
    }
}