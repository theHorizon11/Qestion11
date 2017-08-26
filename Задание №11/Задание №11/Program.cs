using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание__11
{
    class Program
    {
        static string Mainstr;

        static string Шифратор(string str) //Шифрация сообщения
        {
            while (str.Length % 4 != 0) //Дополнение строки пробелами
            {
                str += " ";
            }

            string newstr = "";

            for (int i = 0; i <= str.Length - 4; i += 4)
            {
                newstr += str[i + 2]; //Шифровка первого символа
                newstr += str[i + 1]; //Шифровка второго символа
                newstr += str[i + 3]; //Шифровка третьего символа
                newstr += str[i];     //Шифровка четвертого символа
            }

            return newstr;
        }
        static string Дешифратор(string str) //Дешифрация сообщения
        {
            string newstr = "";

            for (int i = 0; i <= str.Length - 4; i += 4)//
            {
                newstr += str[i+3];   //Дешифровка первого символа
                newstr += str[i + 1]; //Дешифровка второго символа
                newstr += str[i];     //Дешифровка третьего символа
                newstr += str[i+2];   //Дешифровка четвертого символа
            }

            return newstr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для зашифровки");
            Mainstr = Шифратор(Console.ReadLine()); //Ввод строки пользователем
            Console.WriteLine(Mainstr); //Шифровка
            Mainstr = Дешифратор(Mainstr); 
            Console.WriteLine(Mainstr); //Дешифровка
            Console.ReadLine(); //Вывод строки
        }
    }
}
