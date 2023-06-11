#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int answer = 0;
    while(n>10)
    {
        answer+=n%10;
        n=n/10;
    }
    if(n==10)
        answer +=1;
    else
        answer+=n;
    return answer;
}