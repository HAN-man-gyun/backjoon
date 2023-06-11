#include <string>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> solution(vector<int> num_list) {
    vector<int> answer;
    answer.resize(num_list.size());
    int j =0;
    for(int i = num_list.size()-1; i>=0; i--)
    {
        answer[j] = num_list[i];
        j++;
    }
    return answer;
}