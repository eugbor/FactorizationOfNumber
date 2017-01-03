using System;
//Как известно, каждое натуральное число n,n>1, однозначно раскладывается в произведение простых сомножителей,
//например, 13=13, 105=3*5*7, 72=2*2*2*3*3. Разложите натуральное число на простые множители (факторизация числа).
//
namespace FactorizationOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            Show(n);
            Console.ReadLine();
        }
        
        static void Show(double n)
        {
            double t, k;
            Console.WriteLine("{0} =", n);
            if (n<=1)
            {
                Console.WriteLine(" {0}",n);
                return;
            }
            t = Math.Sqrt(n);
            k = 2;
            while (k<=t)
            {
                if (n%k == 0)
                {
                    n /= k;
                    Console.WriteLine(" {0}", k);
                    while (n%k == 0)
                    {
                        n /= k;
                        Console.WriteLine(" {0}", k);
                    }
                    t = Math.Sqrt(n);
                }
                k++;
            }
            if (n > 1)
            {
                Console.WriteLine(" {0}", n);
            }
        } 
    }
}
