#include <string>
#include <vector>
#include <algorithm>
using namespace std;

int solution(vector<int> sides) {
    int answer = 0;
    sort(sides.begin(), sides.end());
    int a =0;
    answer = sides[2];
    sides.pop_back();
    for(auto i : sides)
    {
        a+=i;
    }
    if(a>answer)
        answer =1;
    else
        answer =2;
    return answer;
    
    
}