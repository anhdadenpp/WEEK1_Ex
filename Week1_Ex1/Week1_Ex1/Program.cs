using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Nhap so N : ");
            N = Int32.Parse(Console.ReadLine());// chuyen 1 chuoi ve 1 so nguyen 
            for(int i = 1; i <= N; i++)
            {
                if (checkSNT(i))
                {
                    Console.Write("{0}, ", i);
                }
             
            }
        }
        static bool checkSNT(int num)
        {

            // new num chia het cho 1 trong cac so chay tu 2  =>num/2
            // thi num khong phai la so nguyen to 
            // num la snt khi va chi khi num chia het cho 1 va chinh no
            int max = num / 2;
            for(int i = 2; i <= max; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
