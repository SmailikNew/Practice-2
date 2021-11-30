using ArrayManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library12
{
    public static class Calcualtion
    {
        public static string GetSum(this MyArray myarray)
        {
            int sum = 0;

            for (int i = 0; i < myarray.Length; i++)
            {
                if (myarray[i] < 8)
                {
                    sum += myarray[i];
                }
            }
            return sum.ToString();
        }
    }
}
