
using System;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] s = createarray(n, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(s[i, j] + " ");
                }
                Console.WriteLine();
            }
            summ(s);
        }
        public static int[,] createarray(int n, int m)
        {
            int[,] mas = new int[n, m];
            Random random = new Random();
            for(int i = 0; i <n; i++)
            {
                for(int j = 0; j<m; j++)
                {
                    mas[i, j] = random.Next(-3, 10);
                }
            }
            return mas;
        }
        public static void summ (int[,] mas)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                int p = 0;
                int sum = 0;
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    if(mas[i,j] >= 0)
                    {
                        p++;
                        sum += mas[i, j];
                    }
                }
                if(p == mas.GetLength(0))
                {
                    Console.WriteLine("в {0}-му стовпчику сума дорівнює {1}", j ,sum);
                }
            }
        }
        
    }
}
