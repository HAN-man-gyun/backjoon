#include <string>
#include <vector>

using namespace std;

string solution(vector<string> str_list, string ex) {
    string answer = "";
    int check = -1;
    for(int i =0; i< str_list.size(); i++)
    {
        check = str_list[i].find(ex);
        if(check ==-1)
        {
            answer = answer+str_list[i];
        }
        check =-1;
    }
    return answer;
}