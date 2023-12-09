using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GunbinNA.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] array = { 0, 0, 0, 0, 0 };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    array[j] = matrix[j, 4];
                Array.Sort(array);
                for (int k = 0; k < columns; k++)
                    matrix[k, 4] = array[k];
            }
            return matrix;
        }
    }
}

