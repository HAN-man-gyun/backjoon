#include <string>
#include <vector>

using namespace std;

int solution(vector<string> s1, vector<string> s2) {
    int answer = 0;
    vector<string>::iterator iters1;
    vector<string>::iterator iters2;
    iters2 = s2.begin();
    for(iters1 = s1.begin(); iters1 != s1.end(); iters1++)
    {
        for(iters2; iters2 != s2.end(); iters2++)
        {
            if(*iters1 == *iters2)
            {
                answer ++;
            }
        }
        iters2 = s2.begin();
    }
    
    return answer;
}