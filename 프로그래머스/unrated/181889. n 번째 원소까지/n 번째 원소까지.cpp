#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> num_list, int n) {
    vector<int> answer;
    answer.resize(n);
    for(int i=0; i<n; i++)
    {
        answer[i]=num_list[i];
    }
    
    return answer;
}