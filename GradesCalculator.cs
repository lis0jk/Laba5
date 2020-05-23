using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class GradesCalculator
    {
        public int FindMin(int[] array)
        {
            Array.Sort(array, 0, array.GetLength(0));
            var result = array[0];
            return result;
        }
        public int FindMax(int[] array)
        {
            Array.Sort(array, 0, array.GetLength(0));
            var result = array[array.GetLength(0) - 1];
            return result;

        }
        public double FindAverage(int[] array)
        {
            Array.Sort(array, 0, array.GetLength(0));
            int buf = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                buf += array[i];
            }
            var result = buf / array.GetLength(0);
            return result;
        }
    }
}
