#include <string>
#include <vector>

using namespace std;

string solution(string my_string, int n) {
    string answer = "";
    answer.resize(n);
    for(int i=0; i<n; i++)
    {
        answer[i]=my_string[i]; 
    }
    return answer;
}