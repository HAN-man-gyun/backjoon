#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<string> strlist) {
    vector<int> answer;
   for(int i =0; i<strlist.size(); i++)
   {
       answer.emplace_back(strlist[i].size());
   }
    return answer;
}