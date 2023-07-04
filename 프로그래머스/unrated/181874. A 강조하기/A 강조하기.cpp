#include <string>
#include <vector>

using namespace std;

string solution(string myString) {
    string answer = "";
    for(int i=0; i<myString.length(); i++)
    {
        if(myString[i] =='a')
        {
            myString[i] = myString[i] -32;
        }
    }
    for(int i=0; i<myString.length(); i++)
    {
        if(myString[i] !='A')
        {
            if(myString[i] >=65 && myString[i]<=90)
            {
                myString[i] = myString[i] +32;
            }
        }
        
    }
    answer = myString;
    return answer;
}