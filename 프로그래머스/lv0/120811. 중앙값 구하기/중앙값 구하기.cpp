#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(vector<int> array) {
    int answer = 0;
    sort(array.begin(), array.end());
    for(int i =0; i< array.size() ;i++)
    {
        answer += i;
    }
    answer=answer/array.size();
    answer = array[answer];
    return answer;
}