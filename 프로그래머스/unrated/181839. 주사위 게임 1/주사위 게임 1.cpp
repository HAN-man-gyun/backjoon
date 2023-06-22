#include <string>
#include <vector>

using namespace std;

int solution(int a, int b) {
    int answer = 0;
    if(a%2 !=0 && b%2!=0)
    {
        answer = a*a + b*b;
    }
    else if(a%2 ==0 && b%2 ==0)
    {
        if(b<a)
        {
            answer = a-b;
        }
        else
        {
            answer = b-a;
        }
    }
    else
    {
        answer = (a+b)*2;
    }
    return answer;
}