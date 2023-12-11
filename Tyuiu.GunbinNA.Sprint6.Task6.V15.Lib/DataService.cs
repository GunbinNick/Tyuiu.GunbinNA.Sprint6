using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
namespace Tyuiu.GunbinNA.Sprint6.Task6.V15.Lib
{
    public class DataService : ISprint6Task6V15
    {
        public string CollectTextFromFile(string str, string path)
        {
            string strline = "";
            string[] massline;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    massline = line.Split();
                    strline += massline[massline.Length - 1] + " ";
                }
            }
            strline.Trim();
            return strline;
        }
    }
}
