#include <string>
#include <vector>

using namespace std;

string solution(string my_string) {
    string answer = "";
    answer.resize(my_string.length());
    int j = my_string.length()-1;
    for(int i = 0; i < my_string.length(); i++)
    {
        answer[i] = my_string[j];
        j--;
    }
    return answer;
}