using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace pract9_15_16
{
    internal class Program
    {

        static void Pract9()
        {
            Console.Write("Введите номер задачи: ");
            short numb = short.Parse(Console.ReadLine());
            switch (numb)
            {
                case 1:
                    double a = 0;
                    double b = 2 * Math.PI / 3;
                    int M = 15;
                    double H = (b - a) / M;
                    double x;
                    Console.WriteLine("Таблица значений F ");
                    for (int i = 0; i <= M; i++)
                    {
                        x = a + i * H;
                        double F_x = Math.Tan(x / 2);
                        Console.WriteLine($"x={x:F4}  F(x)={F_x:F4}");
                    }
                    break;

                case 2: // Заданная точность
                    double epsilon = 1e-3;

                    // Переменные для расчёта
                    double sum = 0.0; // Сумма ряда
                    double term = 1.0; // Первый член ряда
                    int n = 1; // Номер текущего члена ряда
                    int k = 0; // Количество итераций

                    double numerator = 1.0; // Числитель для факториала n!
                    double denominator = 1.0; // Знаменатель для факториала (2n)!

                    // Вычисление суммы ряда
                    do
                    {
                        k++;

                        // Обновляем числитель и знаменатель для текущего члена ряда
                        numerator *= n;
                        denominator *= 2 * n - 1;
                        denominator *= 2 * n;

                        // Вычисление текущего члена ряда
                        term = numerator / denominator;

                        // Добавляем текущий член к сумме
                        sum += term;

                        // Переход к следующему члену ряда
                        n++;
                    } while (Math.Abs(term) > epsilon);

                    // Вывод результата
                    Console.WriteLine($"Количество итераций: {k}\t Сумма ряда: {sum:f6}");
                    break;
            }
        }
        static void Pract15_16()
        {
            {
                Console.Write("Введите номер задачи: ");
                short zadacha = short.Parse(Console.ReadLine());
                switch (zadacha)
                {
                    case 1:
                        string example = "xabcxyzabcxabc";
                        string pattern = "x(?=abc)";
                        string result = Regex.Replace(example, pattern, "");

                        Console.WriteLine(result);
                        break;

                    case 2:
                        string primer = "Поставьтепожалуйста5!!!";
                        string resultString = "";

                        foreach (char a in primer)
                        {
                            resultString += a + " ";
                        }

                        Console.WriteLine(resultString);
                        break;
                }

            }
        }



        static void Main(string[] args)
        {
            Console.Write("Введите номер практической работы(9,15 16):");
            short numb = short.Parse(Console.ReadLine());
            switch (numb)
            {
                case 9: Pract9(); break;

                case 15:
                    Pract15_16();
                    break;
            }
            Console.ReadKey();
        }
    }
}