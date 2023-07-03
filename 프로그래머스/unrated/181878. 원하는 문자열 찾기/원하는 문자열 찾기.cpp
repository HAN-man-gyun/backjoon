#include <string>
#include <vector>
#include <cctype>
using namespace std;

int solution(string myString, string pat) {
    int answer = 0;
    for(int i=0; i<pat.length(); i++)
    {
        if(pat[i]>=65 && pat[i]<=90)
        {
            pat[i] = pat[i] +32;
        }
    }
    for(int i=0; i< myString.length(); i++)
    {
         if(myString[i]>=65 && myString[i]<=90)
         {
             myString[i] = myString[i] +32;
         }
    }
    answer=myString.find(pat);
    if(answer>=0)
    {
        answer =1;
    }
    else
    {
        answer =0;
    }
    
    return answer;
}