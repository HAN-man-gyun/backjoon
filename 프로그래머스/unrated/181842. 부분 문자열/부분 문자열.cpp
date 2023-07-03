#include <string>
#include <vector>

using namespace std;

int solution(string str1, string str2) {
    int answer = 0;
     answer=str2.find(str1);
     if(answer >=0)
         answer =1;
    else
        answer =0;
    return answer;
}