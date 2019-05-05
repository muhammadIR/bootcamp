using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    class Program
    {
        static void Main(string[] args)
        {
            Soal01(7, 1, 2);
            Soal01(7, 2, 2);
            Soal01(7, 1, 3);
            Soal01(7, 1, 3);
            Soal02(8, 1, 4);
            Soal03(8, 1, 4);
            Soal04(9, 1, 2);
            Soal05(9, 3, 3);
            Soal06(9, 4, 4);
            Soal07(9, 3, 3);
            LoopingSoal01.Soal01a(7, 1, 2);
            LoopingSoal01.Soal02a(7, 2, 4);

            int jml = SimpleArraySum.simpleArraySum(new int[] { 338, 65, 713, 595, 428, 610, 728, 573, 871, 868 });
            Console.WriteLine(SimpleArraySum.simpleArraySum(new int[] { 1, 2, 3, 4, 10, 11 }));
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Soal01(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 0; i < n; i++)
            {
                Console.Write(angka + " ");
                angka += nIncrement;

            }
            Console.WriteLine();
        }
        static void Soal02(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write(angka + " ");
                    angka += nIncrement;
                }
            }
            Console.WriteLine();
        }
        static void Soal03(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("* ");
                    angka += nIncrement;
                }
                else
                {
                    Console.Write(angka + " ");
                    angka += nIncrement;
                }
            }
            Console.WriteLine();
        }
        static void Soal04(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 1; i < n; i++)
            {
                Console.Write(angka + " ");
                angka *= nIncrement;
            }
            Console.WriteLine();
        }
        static void Soal05(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 1; i < n; i++)
            {
                if (i == 4)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(angka + " ");
                    angka *= nIncrement;
                }
            }
            Console.WriteLine();
        }
        static void Soal06(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write(angka + " ");
                    angka *= nIncrement;
                }
            }
            Console.WriteLine();
        }
        static void Soal07(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 1; i < n; i++)
            {
                if (i == 4)
                {
                    Console.Write("XXX ");
                    angka *= nIncrement;
                }
                else
                {
                    Console.Write(angka + " ");
                    angka *= nIncrement;
                }
            }
            Console.WriteLine();
        }
    }
}