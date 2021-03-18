using System;

namespace SkillBoxArray4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();                                    // создание рандома
            int[] ArrayIncome = new int[13];                              // инициализация массива Дохода
            int[] ArrayExpenses = new int[13];                            // инициализация массива Расхода
            int[] ArrayProfit = new int [13];                             // инициализация массива Прибыль
            int PozitivProfit = 0;                                        // инициализация колличества месяцев с положительной прибылью
            string titul = "Month\t\tIncome\t\tExpenses\tProfit";         // инициализация строки для титульника

            Console.SetCursorPosition((Console.WindowHeight - titul.Length) / 8, Console.CursorTop);    // настройка интерфейса
            Console.WriteLine(titul);                                                                   // вывод титульника после настройки

            for (int i = 1; i < ArrayIncome.Length && i < ArrayExpenses.Length; i++)                    // цикл для заполнение и вывода массивов Дохода и Рассхода, Прибыли
            {
                ArrayIncome[i] = rnd.Next(50000, 120000);                                                           // рандомное значение для массива Доход                           
                ArrayExpenses[i] = rnd.Next(50000, 120000);                                                         // рандомное значение для цикла Расходы
                ArrayProfit [i] = ArrayIncome[i]-ArrayExpenses[i];                                                  // присваивание значение для массива Прибыль
                Console.SetCursorPosition((Console.WindowHeight - ArrayIncome.Length) / 8, Console.CursorTop);      // найстройка вывода     
                Console.WriteLine($"{i}\t\t{ArrayIncome[i]}\t\t{ArrayExpenses[i]}\t\t{ArrayProfit[i]}");            // вывод значений i->month;ArrayIncome->Income;ArrayExpenses->Expenses;Profit->Prof
            }
            Console.Write("\nWorst profit in months: ");                                                 // вывод плохого дохода всё в одну строку
            for (int i = 1; i < ArrayProfit.Length; i++)                                                 // цикл для вывода номерво плохих месяцев и прибыли больше нуля
            {
                if (ArrayProfit[i] > 0) PozitivProfit++;                                                 // если прибыль больше нуля, увеличить кол-во позитивных месяцев прибыли
                if (ArrayProfit[i]<=20000)                                                               // если прибыль меньше либа равна 20000
                {
                    Console.Write($"{i} ");                                                              // вывести в одну строку номер месяца
                }
            }

            Console.WriteLine("\nMonths with a positive profit: {0}",PozitivProfit);                      // вывод полного кол-ва позитивных месяцев 
            Console.ReadKey();                                                                            // ожидание ввода
        }
    }
}
