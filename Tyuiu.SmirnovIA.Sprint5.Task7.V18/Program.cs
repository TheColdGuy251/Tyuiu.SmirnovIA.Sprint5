using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SmirnovIA.Sprint5.Task7.V18.Lib;

namespace Tyuiu.SmirnovIA.Sprint5.Task7.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Смирнов И. А. | ИИПб-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Смирнов Илья Алексеевич | ИИПб-23-3                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine(@"* Дан файл С:\DataSprint5\InPutDataFileTask7V18.txt в котором есть        *");
            Console.WriteLine("* набор символьных данных. Заменить все буквы \"н\" на \"нн\". Полученный     *");
            Console.WriteLine("* результат сохранить в файл OutPutDataFileTask7V18.txt.                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
