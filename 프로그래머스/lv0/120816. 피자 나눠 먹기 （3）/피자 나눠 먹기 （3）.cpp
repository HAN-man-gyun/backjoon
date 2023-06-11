#include <string>
#include <vector>

using namespace std;

int solution(int slice, int n) {
    int answer = 0;
    int rest = n%slice;
    if(rest == 0)
        answer = n/slice;
    else
    {
        answer = n/slice;
        answer++;
    }
        
    return answer;
}