using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GunbinNA.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array;
            int len = (stopValue - startValue) + 1;
            array = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0)
                    array[count] = 0;
                else
                    array[count] = Math.Round(((2 * i + 6) / (Math.Cos(i) + i)) - 3, 2);
                count++;
            }
            return array;
        }
    }
}
