using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gd1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[10];
            int num;
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                mass[i] = random.Next(0, 10);
            }
            Console.WriteLine(string.Join(", ", mass));
            Console.WriteLine("input number");
            string s = Console.ReadLine();
            while(!int.TryParse(s, out num))
            {
                Console.WriteLine("wrong number");
                s = Console.ReadLine();
            }
            foreach (int n in mass)
            {
                if (n != num)
                {
                    Console.Write(n - num + ", ");
                }
            }
        }
    }
}
