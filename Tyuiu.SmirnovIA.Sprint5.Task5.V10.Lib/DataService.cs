﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SmirnovIA.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    double num = Convert.ToDouble(line);
                    if (num == Math.Round(num) && (num % 2 == 0)) 
                    {
                        res += num;
                    }
                }
            }
            return res;
        }
    }
}
