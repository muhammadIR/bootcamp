using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuaAngka
{
    class Program
    {
        static void Main(string[] args)  {

            Console.WriteLine("selamat datang Batch 196");

            //Source untuk comment ctrl+k+c
            //Source untuk uncomment ctrl+k+u
            //Menangkap Angka Pertama
            Console.Write("Masukan Angka Pertama");
            int _angka1 = Int16.Parse(Console.ReadLine());
            //Menangkap Angka Kedua
            Console.Write("Masukan Angka Kedua");
            int _angka2 = Int16.Parse(Console.ReadLine());
            //untuk mencetak hasil perubahan dari variable angka1 dan angka2
            Console.WriteLine((_angka1 + _angka2).ToString() + " Ini Hasilnya");

            Console.ReadLine();
        }
    }
}
