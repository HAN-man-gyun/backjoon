using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[] {0,0};
        int maxX = (board[0]-1)/2;
        int minX = -(board[0]-1)/2;
        int maxY = (board[1]-1)/2;
        int minY = -(board[1]-1)/2;
        
        foreach(string a in keyinput)
        {
            switch(a)
            {
                case "left": answer[0] -=1;
                    if(answer[0]<minX)
                    {
                        answer[0] =minX;
                    }
                    break;
                case "right":answer[0] +=1;
                    if(answer[0]>maxX)
                    {
                        answer[0] =maxX;
                    }
                    break;
                case "up":answer[1] +=1;
                    if(answer[1]>maxY)
                    {
                        answer[1] =maxY;
                    }
                    break;
                case "down":answer[1] -=1;
                    if(answer[1]<minY)
                    {
                        answer[1] =minY;
                    }
                    break;
            }
        }
        return answer;
    }
}