﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping1
{
    public class Looping1Soal01
    {
        public static void Soal01a(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
                for (int i=0; i<n; i++)
                {
                    Console.Write(angka+" ");
                    angka*= nIncrement;
                }
            Console.WriteLine();
        }
        public static void Soal01a(int n, int nAwal, int nIncrement)
        {
            int angka = nAwal;
            for (int i = 0; i < n; i++)
            {
                Console.Write(angka + " ");
                angka *= nIncrement;
            }
            Console.WriteLine();
        }
    }
}
