#include <string>
#include <vector>

using namespace std;

string solution(string myString) {
    string answer = "";
    answer.resize(myString.size()) ;
    for(int i=0; i<myString.size(); i++)
    {
        if((myString[i] >=97)&&(myString[i]<=122))
        {
            answer[i] = myString[i];
        }
        else
        {
            
            answer[i]=myString[i]+32;
        }
    }
    return answer;
}