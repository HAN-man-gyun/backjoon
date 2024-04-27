#include <string>
#include <vector>

using namespace std;

string solution(string my_string, int n) {
    string answer = "";
    for(char a : my_string)
    {
        for(int j=1; j<=n; j++)
        {
            answer += a;
        }
    }
    return answer;
}