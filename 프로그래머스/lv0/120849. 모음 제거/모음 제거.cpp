#include <string>
#include <vector>

using namespace std;

string solution(string my_string) {
    string answer = "";
    string m = "aeiou";
    for(int i=0; i<my_string.length(); i++)
    {
        for(int j =0; j<5; j++)
        {
            if(my_string[i] == m[j])
            {
                my_string[i] = my_string[i] - m[j];
            }
        }
        if(my_string[i]!=0)
        {
            answer = answer + my_string[i];
        }
    }
    
    
    return answer;
}