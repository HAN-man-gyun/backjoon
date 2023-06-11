#include <string>
#include <vector>

using namespace std;

string solution(string my_string, int n) {
    string answer = "";
    answer.resize(n);
    for(int i=my_string.size(); i>=my_string.size()-n &&(i>=0); i--)
    {
       
        answer[i-(my_string.size()-n)] = my_string[i];
    }
    
    return answer;
}