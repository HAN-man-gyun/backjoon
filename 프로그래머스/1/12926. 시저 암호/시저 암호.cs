public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        for(int i=0; i<s.Length; i++)
        {
            if(s[i]>=65 && s[i]<=90)
            {
                if(s[i]+n <=90)
                {
                    answer += (char)(s[i] +n);
                }
                else
                {
                    answer += (char)('A'+(s[i]+n -91));
                }
            }
            else if(s[i]>=97 && s[i]<=122)
            {
                if(s[i]+n <=122)
                {
                    answer += (char)(s[i] +n);
                }
                else
                {
                    answer += (char)('a'+(s[i]+n -123));
                }
            }
            else
            {
                answer +=s[i];
            }
        }
        return answer;
    }
}