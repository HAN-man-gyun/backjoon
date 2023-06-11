#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> numbers, int num1, int num2) {
    vector<int> answer;
    answer.resize(num2-num1+1);
    int i =0;
    for(num1 ; num1<=num2; num1++)
    {
        answer[i]=numbers[num1];
        i++;
    }
    return answer;
    
}