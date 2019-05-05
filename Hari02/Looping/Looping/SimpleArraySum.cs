using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Looping
{
    public class SimpleArraySum
    {
        public static int simpleArraySum(int[] ar)
        {
            int hasil = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                hasil += ar[i];
            }
            return hasil;
        }
    }
}
