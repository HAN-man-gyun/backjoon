#include <string>
#include <vector>

using namespace std;

string solution(string my_string, vector<int> index_list) {
    string answer = "";
    answer.resize(index_list.size());
    for(int i = 0; i < index_list.size(); i++)
    {
        answer[i] = my_string[index_list[i]];
    }
    return answer;
}