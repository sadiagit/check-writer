using System;

namespace ConsoleApp1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Program p = new Program();
            // p.print(2, 3, 8);
            // int[] arr = { 2, 11, 15, 20 };
            // p.print(arr);
            //// Console.ReadLine();


            // char x = 'A';
            // int i = 0;
            // Console.WriteLine(true ? x : 0);
            // Console.WriteLine(false ? i : x);


            // //var actions = new List<int>();
            // //for (int j = 0; j < 4; j++) actions.Add(() => Console.WriteLine(j));
            // //foreach (var action in actions)
            // //    action();

            // StringBuilder sb1 = new StringBuilder("TechBeamers");
            // StringBuilder sb2 = new StringBuilder("TechBeamers");

            // Console.WriteLine(sb1.Equals(sb2));

            // double num1 = 1.000001;
            // double num2 = 0.000001;
            // Console.WriteLine((num1 - num2));

            // for (int k = 0; k < 10; k++)
            // {
            //     Console.Write(k + " ");
            // }

            //Console.Write("Enter the length of the Fibonacci Series: ");
            //int length = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0} ", FibonacciSeries(i));
            //}

            string s = "abcde";
            for(int i=s.Length - 1;i>=0; i--)
            {
                Console.Write(s[i]);
            }

        }
        public static int FibonacciSeries(int n)
        {
            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
        public void print(params int[] b)
        {
            foreach (int i in b)
            {
                Console.WriteLine(i);
            }
        }
    }
}
