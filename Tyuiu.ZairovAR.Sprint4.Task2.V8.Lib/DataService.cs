﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZairovAR.Sprint4.Task2.V8.Lib
{
    public class DataService : ISprint4Task2V8
    {
        public int Calculate(int[] array)
        {
            int x = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 2 && array[i] <= 7 && array[i] % 2 != 0) 
                {
                    x += array[i];
                }
                    
            }
            return x;
        }
    }
}
