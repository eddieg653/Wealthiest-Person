using System;

namespace Wealthiest_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] accounts = new int [3][] {
                               new int [3]{100, 200, 300 },
                               new int [1]{500},
                               new int [4]{400, 600, 500, 0},
             };
            Console.WriteLine(ReturnHighest(accounts));
        }
        static int ReturnHighest(int[][] MyAccount)
        {
            int WealthyBoi = 0;
            for (int i = 0; i < MyAccount.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < MyAccount[i].Length; j++)
                {
                    sum += MyAccount[i][j];
                }
                if (sum > WealthyBoi)
                {
                    WealthyBoi = sum;
                }
            }
            return WealthyBoi;
        }
    }
}
