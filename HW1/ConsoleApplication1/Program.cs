using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1{
    class Program{

        static void Main(string[] args){//이 프로그램 안에서 최초로 불리는 함수임

            /////////////////////////////////////////////////////////////////////////
            /*FizzBuzz 3,5 
            for(int i = 1; i<=100; i++)
            {
                if (i % 3 == 0) Console.Write("Fizz");
                if (i % 5 == 0) Console.Write("Buzz");
                if (i % 3 != 0 && i % 5 != 0) Console.Write(i);
                Console.WriteLine("");
            }*/
            /////////////////////////////////////////////////////////////////////////

            int n = 4;
            int[] towerA = { 4, 3, 2, 0 };
            int[] towerB = { 1, 0, 0, 0 };
            int[] towerC = { 0, 0, 0, 0 };
            PrintTowers(n, towerA, towerB, towerC);

        }

        static void PrintTowers(int n, int[] towerA, int[] towerB, int[] towerC)
        {
            for (int i = n-1; i >=0; i--)
            {
                for (int j = towerA[i]; j < n + 1; j++)
                    Console.Write(" ");
                for (int j = 0; j < towerA[i]; j++)
                    Console.Write("*");
                Console.Write("|");
                for (int j = 0; j < towerA[i]; j++)
                    Console.Write("*");
                for (int j = towerA[i]; j < n + 1; j++)
                    Console.Write(" ");
                Console.Write("  ");
                for (int j = towerB[i]; j < n + 1; j++)
                    Console.Write(" ");
                for (int j = 0; j < towerB[i]; j++)
                    Console.Write("*");
                Console.Write("|");
                for (int j = 0; j < towerB[i]; j++)
                    Console.Write("*");
                for (int j = towerB[i]; j < n + 1; j++)
                    Console.Write(" ");
                Console.Write("  ");
                for (int j = towerC[i]; j < n + 1; j++)
                    Console.Write(" ");
                for (int j = 0; j < towerC[i]; j++)
                    Console.Write("*");
                Console.Write("|");
                for (int j = 0; j < towerC[i]; j++)
                    Console.Write("*");
                for (int j = towerC[i]; j < n + 1; j++)
                    Console.Write(" ");
                Console.WriteLine();
            }
        }


    }
}
