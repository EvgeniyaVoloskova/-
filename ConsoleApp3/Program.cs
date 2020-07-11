using ConsoleApp3.Persons;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    { 
        static void Main(string[] args)
        {
            /**
             * 1. Классы для студентов и преподавателей
             * 2. репозиторий дляхранения списков
             * 3. Прогнрамма которая выполняет 3 д-я
             * - вывод списка преподав
             * - вывод списка студентов
             * - выход
             * 4. паттерн команда
             * */
            //AbstractPerson
            //Student
            //- group
            //Teacher
            // -classroom
            //bool isExit = false;
            //do
            //{
            //    /**
            //     * string command =ReadLine();
            //     * CommandProcessor commandProcessor;
            //     * isExit = commandProcessor.ProcessCommand(Command);
            //     * */
            //} while (!isExit);

            Sum(2, 3);
            Sum(2, 3, 4);
            Sum(new int[] { 2, 2 });
            WriteLine(Sum(2, 3));
            WriteLine(Sum(2, 3,4));
            WriteLine(Sum(2, 3,2,45,58,4,6));
           ConsoleKeyInfo symbol;
            int count = 0;
            do
            {
                symbol = ReadKey();
                if (symbol.KeyChar != ' ')
                {
                    count++;
                }
                    
            } while (symbol.KeyChar != '.');

            WriteLine($"probely {count}");
        }
        //static int  Sum(int a,int b,int c=0)
        // {
        //     return a + b+c;
        // }
        //static int Sum(int [] a)
        //{
        //    int i = 0;
        //    foreach(int b in a)
        //    {
        //        i += b;
        //    }
        //    return i;
        //}
        static int Sum(params int[] a)
        {
            int i = 0;
            foreach (int b in a)
            {
                i += b;
            }
            return i;
        }
    }
}
