using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) {
        bool answer = true;
        bool temp1 = false;
        bool temp2 = false;
        temp1 = (x1 == true || x2 == true) ? true : false;
        temp2 = (x3 == true || x4 == true) ? true : false;
        answer = (temp1 == true && temp2 == true) ? true : false;
        return answer;
    }
}