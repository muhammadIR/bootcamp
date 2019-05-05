using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping1
{
    class Program
    {
        static void Main(string[] args)
        {
            Soal01(7, 0, 1);
            Looping1Soal01.Soal01a(7, 1, 3);
        

            Console.ReadKey();
    }

        static void Soal01(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
                for (int i=0; i<7; i++)
                {
                    Console.Write(angka+" ");
                    angka+= nIncrement;
                }
            Console.WriteLine();
        }
    }
}
