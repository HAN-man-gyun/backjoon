#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) {
    int answer = 0;
    int plusSum =0;
    int multiplySum =1;
    for(int i=0; i<num_list.size();i++)
    {
        multiplySum *=num_list[i];
    }
    for(int i=0; i<num_list.size();i++)
    {
        plusSum += num_list[i];
    }
    if(multiplySum >plusSum*plusSum)
    {
        return 0;
    }
    else
    {
        return 1;
    }
    
}