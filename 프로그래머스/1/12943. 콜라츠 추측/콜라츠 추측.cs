public class Solution {
    public int solution(int num) {
        int answer = 0;
        long temp = (long)num;
     if(temp ==1)
     {
         answer =0;
     }
    else
    {
        while(temp!=1)
     {
         
        if(answer >500)
        {
            answer = -1;
            break;
        }
         if(temp %2 ==0)
         {
             temp = temp/2;
         }
         else
         {
             temp = temp*3 +1;
         }
         answer++;
     }
    }  
        return answer;
    }
}