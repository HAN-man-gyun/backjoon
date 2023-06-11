#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> numbers) {
    vector<int> answer;
    answer.resize(numbers.size());
    for(auto& i : numbers)
    {
        i = 2*i;
    }
    for(int j = 0; j<answer.size(); j++)
    {
        answer[j] = numbers[j];
    }
    return answer;
}