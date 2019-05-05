using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                ////Program Hello World
                //Console.WriteLine("Hello World");
                //Console.ReadLine();


                // n adalah nilai variable
                int n = 9;
                // nT adalah nilai tengah dari variable
                int nT = (n - 1) / 2;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        // untuk i <= j adalah arsiran ruang 2, 3, 4, 5
                        // untuk arsiran ruang 2 dibatasi dengan nilai tengah atau nT
                        // nT digunakan terhadap variabel j
                        // dengan menggunakan operator logical AND atau &&
                        // ---------------------------------------------------------
                        // untuk menambah ruang arsiran 3 diperlukan operator logikal
                        // operator yang digunakan adalah OR atau ||
                        // lalukan langkah yang sama seperti membuat arsian ruang 2
                        // dengan rumusan i + j <= n -1 untuk arsiran ruang 1, 2, 3, 8
                        // dibatasi dengan operator logikal && denga j > nT                    
                        if (i <= j && j <= nT || i + j <= n - 1 && j >= nT || 
                            i >= j && j >= nT || i + j >= n - 1 && j <= nT )
                        {
                            Console.Write("* \t");
                        }
                        else
                        {
                            Console.Write("\t");
                        }
                    }
                    // setalh looping terhadap perubahan kolom selesai
                    // maka terjadi perubahan baris
                    // cara melakukan perubahan baris dengan cara
                    // console writeLine 
                    Console.WriteLine("");
                }
                Console.ReadLine();
            }
        }
    }
}
