using System;

namespace main
{
    class program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int a = 0;
                int b = 0;
                int temp1 = Convert.ToInt32(input[0]);
                int temp2 = Convert.ToInt32(input[1]);
                if (temp1 > temp2)
                {
                    a = temp1;
                    b = temp2;
                }
                else
                {
                    a = temp2;
                    b = temp1;
                }

                int f = 0;
                int GCD = 0;
                int LCM = 0;
                int originA = a;
                int originB = b;
                do
                {
                    f = a % b;
                    if (f == 0)
                    {
                        break;
                    }
                    a = b;
                    b = f;
                } while (true);
                GCD = b;

                LCM = originA * originB / GCD;
                Console.WriteLine(LCM);

            }

        }
    }
}