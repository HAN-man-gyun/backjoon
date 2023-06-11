#include <string>
#include <vector>

using namespace std;

vector<int> solution(int money) {
    vector<int> answer;
    answer.resize(2);
    while(money >= 5500)
    {
        money = money-5500;
        answer[0] += 1;
    }
    answer[1] = money;
    return answer;
}