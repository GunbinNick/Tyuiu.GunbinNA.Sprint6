using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.GunbinNA.Sprint6.Task5.V6.Lib
{
    public class DataService : ISprint6Task5V6
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    len++;
            }
            double[] array = new double[len];
            int i = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    array[i] = Convert.ToDouble(line);
                    i++;
                }
            }
            double[] nums = new double[len];
            for (int j = 0; j < array.Length; j++) 
            {
                if (array[j] % 3.0 == 0)
                    nums[j] = (double)array[j];
            }
            return nums;
        }
    }
}
