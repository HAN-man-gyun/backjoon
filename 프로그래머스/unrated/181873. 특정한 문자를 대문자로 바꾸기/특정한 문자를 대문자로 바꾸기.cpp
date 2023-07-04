#include <string>
#include <vector>
#include <cstring>
using namespace std;

string solution(string my_string, string alp) {
    string answer = "";
    char a[2];
    strcpy(a,alp.c_str());
    for(int i=0; i<my_string.size(); i++)
    {
        if(my_string[i] == a[0])
        {
            my_string[i] = my_string[i]-32;
        }
    }
    answer = my_string;
    return answer;
}