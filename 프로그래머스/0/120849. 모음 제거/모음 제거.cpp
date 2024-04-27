#include <string>
#include <vector>

using namespace std;

string solution(string my_string) {
    string answer = "";
    for(char a : my_string)
    {
        if(a == 'a' || a== 'e' || a=='i' || a=='o' || a=='u')
        {
            
        }
        else
        {
            answer +=a;
        }
    }
    return answer;
}