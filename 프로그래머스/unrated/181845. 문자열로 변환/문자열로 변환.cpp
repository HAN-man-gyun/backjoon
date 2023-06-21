#include <string>
#include <vector>

using namespace std;

string solution(int n) {
    string answer = "";
    answer.resize((to_string(n)).size());
    answer=to_string(n);
    return answer;
}