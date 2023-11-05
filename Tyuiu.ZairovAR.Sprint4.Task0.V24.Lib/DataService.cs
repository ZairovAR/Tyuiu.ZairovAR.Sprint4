using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZairovAR.Sprint4.Task0.V24.Lib
{
    public class DataService : ISprint4Task0V24
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int p = 1;
            for (int i = 0; i < array.Length; i++ ) 
            {
                if (array[i] % 2 == 0)
                {
                    p *= array[i];

                }
            }
            return p;
        }
    }
}
