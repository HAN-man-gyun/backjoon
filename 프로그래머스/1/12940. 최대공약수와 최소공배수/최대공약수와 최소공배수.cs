public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int max = n>m ? n:m;
        for(int i =1; i<=n; i++)
        {
            if(n%i ==0 && m%i==0)
            {
                answer[0] =i;
            }
        }
        while(!(max %n==0 && max %m==0))
        {
            max++;
        }
        answer[1] =max;
        
        return answer;
    }
}