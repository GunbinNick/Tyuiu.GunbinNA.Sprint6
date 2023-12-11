using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GunbinNA.Sprint6.Task7.V1.Lib
{
    public class DataService : ISprint6Task7V1
    {
        public int[,] GetMatrix(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int xCol = 1;
            for (int i = 0; i < rows; i++)
                for (int j = xCol; j <= xCol; j++)
                    if (matrix[i, j] < 0)
                        matrix[i, j] = 1;
            return matrix;
        }
    }
}
