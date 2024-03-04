using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pr_21_13._1_ZelinaEkaterina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArrayList list = new ArrayList();
                list.AddRange(new string[] { "3.2", "21", "Студент", "Олег" });
                ArrayList list1 = new ArrayList();
                list1.AddRange(new string[] { "4.9", "27", "Рабочая", "Медведева" });
                WriteLine("Введите с какой позиции хотите вставить новую коллекцию");
                int n = int.Parse(ReadLine());
                WriteLine("Введите какое количество элементов вы хотите удалить");
                int k = int.Parse(ReadLine());
                WriteLine("-------------------------------");
                if (n > 0 && k > 1)
                {
                    list.InsertRange(n, list1);
                    foreach (object e in list)
                    {
                        WriteLine(e);
                    }
                    WriteLine("-------------------------------");
                    n = n / 2;
                    WriteLine("Удаляем заданное кол-во символов");
                    WriteLine("-------------------------------");
                    for (int i = 0; i < k; i++)
                    {
                        list.RemoveAt(n);
                    }
                    foreach (object e in list)
                    {
                        WriteLine(e);
                    }
                    WriteLine("-------------------------------");
                }
                else
                {
                    WriteLine("error, недопустимые значения");
                }

                ReadKey();
            }
            catch
            {
                WriteLine("введен символ");
            }
        }
    }
}
