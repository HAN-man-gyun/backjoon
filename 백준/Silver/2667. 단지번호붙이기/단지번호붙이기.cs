using System;

namespace BJ
{
    public class DFS
    {
        // 실제 배열
        public int[,] array;
        // 탐색한노드인지 아닌지 확인할 배열
        public bool[,] boolArray;
        // 최대 행 크기
        public int maxRow;
        // 최대 열 크기
        public int maxColumn;
        // 단지 크기 배열
        public List<int> apart;
        // 단지 크기
        public int size;
        public DFS(int[,] array)
        {
            this.array = array;
            maxRow = array.GetLength(0);
            maxColumn = array.GetLength(1);
            boolArray = new bool[maxRow, maxColumn];
            apart = new List<int>();
        }

        public void Search ()
        {
            for(int i=0; i<maxRow; i++)
            {
                for(int j=0; j<maxColumn; j++)
                {
                    if (array[i,j] == 1 && boolArray[i,j] == false)
                    {
                        size = 0;
                        //현재 배열을 true로 바꿔주고.
                        boolArray[i, j] = true;
                        //DFS를 통해서 단지의 크기를 구해주고 크기리스트에 Add 
                        DFSSearch(i,j);
                        apart.Add(size);
                    }
                }
            }
        }
        public void DFSSearch(int x, int y)
        {
            int[] dx = { -1, 0, 1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            size++; // 단지의 크기 증가
            for (int i = 0; i < 4; i++)
            {
                int nextX = x + dx[i];
                int nextY = y + dy[i];

                // 배열 범위를 벗어나지 않고, 아직 방문하지 않은 유효한 좌표인 경우
                if (nextX >= 0 && nextX < maxRow && nextY >= 0 && nextY < maxColumn &&
                    array[nextX, nextY] == 1 && !boolArray[nextX, nextY])
                {
                    // 현재 좌표를 방문했음을 표시하고 큐에 추가
                    boolArray[nextX, nextY] = true;

                    DFSSearch(nextX, nextY);
                }
            }
        }

        public void AscendingSort()
        {
            apart.Sort();
        }
    }

    
    public class MainApp
    {
      
        public static void Main(String[] args)

        {
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int[] output;

            int[,] myMap = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                string input2 = Console.ReadLine();
                output = new int[input2.Length];
                for (int k = 0; k < input2.Length; k++)
                {
                    output[k] = Convert.ToInt32(input2[k] - '0');
                }
                int[] tempMap = output;
                for (int j=0; j<n; j++)
                {
                    myMap[i, j] = tempMap[j];
                }
            }

           /* Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
               
                for (int j = 0; j < n; j++)
                {
                    Console.Write(myMap[i, j]);
                }
                Console.WriteLine();
            }*/


            DFS dfs = new DFS(myMap);
            dfs.Search();
            dfs.AscendingSort();
            Console.WriteLine(dfs.apart.Count);
            for(int i=0; i<dfs.apart.Count; i++)
            {
                Console.WriteLine(dfs.apart[i]);
            }

        }

       
    }
}