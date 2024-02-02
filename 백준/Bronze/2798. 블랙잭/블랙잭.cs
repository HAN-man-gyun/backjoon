using System;
using System.Collections.Generic;

namespace program
{
    class main
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(" ");
            int N = Convert.ToInt32(first[0]);
            int M = Convert.ToInt32(first[1]);
            string[] second = Console.ReadLine().Split(" ");
            int result = 0;
            int[] combination = new int[3];
            List<int> cardList = new List<int>();
            for (int i = 0; i < N; i++)
            {
                cardList.Add(Convert.ToInt32(second[i]));
            }

            int diff = int.MaxValue;


            for(int i = 0; i < N - 2; i++)
            {
                for(int j = i + 1; j < N - 1; j++)
                {
                    for(int k = j + 1; k < N; k++)
                    {
                        int sum = cardList[i] + cardList[j] + cardList[k];
                        int difforigin  = Math.Abs(sum -M);
                        if(sum<=M &&difforigin <diff)
                        {
                            diff = difforigin;
                            combination[0] = cardList[i];
                            combination[1] = cardList[j];
                            combination[2] = cardList[k];
                        }
                    }
                }
            }
            Console.WriteLine(combination[0] + combination[1] + combination[2]);

        
        }
    }
}