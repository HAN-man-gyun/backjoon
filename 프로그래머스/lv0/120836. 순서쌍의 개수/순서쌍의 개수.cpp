#include <string>
#include <vector>
#include <cmath>
#include <algorithm>
using namespace std;

int solution(int n) {
    int answer = 0;
    vector<int> numbers;
    for(int i =1; i <= sqrt(n); i++)
    {
        if(n%i ==0)
        {
            numbers.push_back(i);
            if(n/i != i)
            {
                numbers.push_back(n/i);
            }   
        }
    }
    answer = numbers.size();
    return answer;
}