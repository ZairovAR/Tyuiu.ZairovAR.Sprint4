using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZairovAR.Sprint4.Task1.V15.Lib
{
    public class DataService : ISprint4Task1V15
    {
        public int Calculate(int[] array)
        {
           int c = 1;
           for (int i = 0; i < array.Length; i++) 
           {
                if (array[i] >= 4 && array[i] <= 9)
                {
                    if (array[i] % 2 == 0) 
                    {
                        c *= array[i];
                    }
                }

           }
           return c;

        }
    }
}
