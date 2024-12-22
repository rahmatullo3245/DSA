using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace binary_search
{
    public class programm
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++) {
                a[i] = rand.Next(10, 101);
            }
            Array.Sort(a);
            for (int i = 0; i < n; i++){
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();
            int t = a[rand.Next(a.Length)];
            Console.WriteLine(t);
            int low = 0;
            int high = a.Length;
            while (low <= high) { 
                int med = (low + high) / 2;
                if (a[med] == t)
                {
                    Console.WriteLine("target>>>>>>" + t);
                    break;
                }
                else if (a[med] < t){
                    Console.WriteLine("searching right......");
                    low = med + 1;
                }
                else {
                    Console.WriteLine("searching left.......");
                    high = med - 1;
                }
            }
        }
    }
}