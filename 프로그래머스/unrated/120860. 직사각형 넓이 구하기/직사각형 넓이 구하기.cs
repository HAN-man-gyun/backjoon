using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int maxX = -257;
        int minX = 257;
        int maxY = -257;
        int minY = 257;
        for(int i=0; i< dots.GetLength(0); i++)
        {
            if( dots[i,0] >maxX)
            {
                maxX = dots[i,0];
            }
            if( dots[i,0] <minX)
            {
                minX = dots[i,0];
            }
            if( dots[i,1] >maxY)
            {
                maxY = dots[i,1];
            }
            if( dots[i,1] <minY)
            {
                minY = dots[i,1];
            }
        }
        int x =0;
        int y =0;
        if(maxX<0&& minX<0)
        {
            x = Math.Abs(minX)-Math.Abs(maxX);
        }
        else
        {
            x = maxX-minX;
        }
        
        if(maxY<0&& minY<0)
        {
            y = Math.Abs(minY)-Math.Abs(maxY);
        }
        else
        {
            y = maxY-minY;
        }
        
        answer = x * y;
        
        return answer;
    }
}