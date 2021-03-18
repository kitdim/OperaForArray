using System;

namespace SkillBox4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();  // создание рандома
            while (true)                // начала цикла строка 10
            {
                Console.Clear();        // очистить консоль после возвращения к циклу
                Console.Write("Введите количество строк: "); int stroka = int.Parse(Console.ReadLine());        // ввод строк
                Console.Write("Введите количество столбцов: "); int stolbec = int.Parse(Console.ReadLine());    // ввод столбцов
                Console.Clear();        // очистить консоль 
                if (stroka == stolbec)  // если строка = столбцу
                {
                    Console.Write("Какой тебе нужен пункт:1/2/3 ? "); string task = Console.ReadLine(); Console.Clear();    // ввод в консоль нужного пункта, далее очистка консоли
                    #region Task 1 перемножить рандомно созданный массив на введенный с клавиатуры множитель 
                    if (task == "1")    // если задача = 1
                    {
                        Console.Write("Введите число на которое хотите умножить: "); int number = int.Parse(Console.ReadLine());        // ввод множителя
                        int[,] arraySelection = new int[stroka, stolbec];   // присваивание первому двухмерному массиву его количество строк и столбцов 
                        int[,] arrayPlus = new int[stroka, stolbec];        // присваивание массиву произведения его количество строк и столбцов
                        Console.Clear();
                        for (int i = 0; i < stroka; i++)                    // цикл перехода на новую строку
                        {
                            for (int j = 0; j < stolbec; j++)               // цикл перехода на новый столбец
                            {
                                arraySelection[i, j] = rdn.Next(10);        // заполнения массива 
                                arrayPlus[i, j] = arraySelection[i, j];     // заполнение массива вывода значений
                                Console.Write($"\t{arraySelection[i, j]} ");    // вывод массива 
                            }
                            Console.WriteLine();                                // переход на новую строку
                        }
                        Console.WriteLine($"\n\t\t      * {number}" +           // вывод множителя и нижнего прочерка       
                                          "\n\t__________________");

                        for (int i = 0; i < stroka; i++)                        // = строка 26
                        {
                            for (int j = 0; j < stolbec; j++)                   // = строка 28
                            {
                                arrayPlus[i, j] *= number;                      // операция перемножения каждый шаг цикла на множитель
                                Console.Write($"\t{arrayPlus[i, j]}");          // вывод множителя
                            }
                            Console.WriteLine();
                        }

                        Console.Write("\nХочешь посмотреть другие пункты да/нет ? "); string otvet = Console.ReadLine();    // вывод ответа
                        if (otvet == "да") continue;        // условие на продолжения , есла да==продолжить
                        else if (otvet == "нет") break;    // выход  
                        else { Console.WriteLine("Ошибка..."); Console.ReadKey(); break; } // выход
                    }
                    #endregion
                    #region Task 2 Выполнить операцию разности или сложения
                    else if (task == "2")
                    {
                        int[,] OneArraySelection = new int[stroka, stolbec]; // инициализация первого массива
                        int[,] TwoArraySelection = new int[stroka, stolbec]; // инициализация второго массива
                        int[,] arrayPlus = new int[stroka, stolbec];    // инициализация массива суммы
                        int[,] arrayMinus = new int[stroka, stolbec];   // инициализация массива разности
                        Console.Write("Тебе нужна операция сложения или вычитания +/-? "); string PlusOrMinus = Console.ReadLine(); // ввод нужной операции
                        switch (PlusOrMinus) // конструкция где заполнются рандомными значениями 2 массива, далее на выбор операция сложения или вычитания, в последующем вывод массива значения
                        {
                            case "+": // выбор операции сложения
                            {
                                    for (int i = 0; i < stroka; i++)
                                    {
                                        for (int j = 0; j < stolbec; j++)
                                        {
                                            OneArraySelection[i, j] = rdn.Next(10);
                                            Console.Write($"\t{OneArraySelection[i, j]} ");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine("+");
                                    for (int i = 0; i < stroka; i++)
                                    {
                                        for (int j = 0; j < stolbec; j++)
                                        {
                                            TwoArraySelection[i, j] = rdn.Next(10);
                                            Console.Write($"\t{TwoArraySelection[i, j]} ");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine("\t_________________");
                                    for (int i = 0; i < stroka; i++)
                                    {
                                        for (int j = 0; j < stolbec; j++)
                                        {
                                            arrayPlus[i, j] = OneArraySelection[i, j] + TwoArraySelection[i, j];
                                            Console.Write($"\t{arrayPlus[i, j]} ");
                                        }
                                        Console.WriteLine();
                                    }
                                    break;
                            }
                            case "-": // выбор операции вычитания 
                                {
                                    for (int i = 0; i < stroka; i++)
                                    {
                                        for (int j = 0; j < stolbec; j++)
                                        {
                                            OneArraySelection[i, j] = rdn.Next(10);
                                            Console.Write($"\t{OneArraySelection[i, j]} ");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine("-");
                                    for (int i = 0; i < stroka; i++)
                                    {
                                        for (int j = 0; j < stolbec; j++)
                                        {
                                            TwoArraySelection[i, j] = rdn.Next(10);
                                            Console.Write($"\t{TwoArraySelection[i, j]} ");
                                        }
                                        Console.WriteLine();
                                    }
                                    Console.WriteLine("\t_________________");
                                    for (int i = 0; i < stroka; i++)
                                    {
                                        for (int j = 0; j < stolbec; j++)
                                        {
                                            arrayMinus [i, j] = OneArraySelection[i, j] - TwoArraySelection[i, j];
                                            Console.Write($"\t{arrayMinus[i, j]} ");
                                        }
                                        Console.WriteLine();
                                    }
                                }
                                break;

                            default: // значение введенное не определенно кейсом 
                                Console.WriteLine("Ошибка...");
                                break; // выход 
                        } 
                        Console.WriteLine(); // переход на новую строку 
                        Console.Write("Хочешь посмотреть другие пункты да/нет ? "); string otvet = Console.ReadLine();
                        if (otvet == "да") continue;    // = строка 50
                        else if (otvet == "нет") break; // = строка 51
                        else { Console.WriteLine("Ошибка..."); Console.ReadKey(); break; }  // = стркоа 52
                    }
                    #endregion
                    #region Task 3 Выполнить перемножения двух массивов 
                    else if (task == "3")   // если задача = 3
                    {
                        Console.Clear();
                        int[,] OneArraySelection = new int[stroka, stolbec];
                        int[,] TwoArraySelection = new int[stroka, stolbec];
                        int[,] MultiArray = new int[stroka, stolbec];
                        for (int i = 0; i < stroka; i++)
                        {
                            for (int j = 0; j < stolbec; j++)
                            {
                                OneArraySelection[i, j] = rdn.Next(10);
                                Console.Write($"\t{OneArraySelection[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("*");
                        for (int i = 0; i < stroka; i++)
                        {
                            for (int j = 0; j < stolbec; j++)
                            {
                                TwoArraySelection[i, j] = rdn.Next(10);
                                Console.Write($"\t{TwoArraySelection[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("\t_________________");
                        for (int i = 0; i < stroka; i++)
                        {
                            for (int j = 0; j < stolbec; j++)
                            {
                                MultiArray[i, j] = OneArraySelection[i, j] * TwoArraySelection[i, j];
                                Console.Write($"\t{MultiArray[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        Console.Write("Хочешь посмотреть другие пункты да/нет ? "); string otvet = Console.ReadLine();
                        if (otvet == "да") continue;
                        else if (otvet == "нет") break;
                        else { Console.WriteLine("Ошибка..."); Console.ReadKey(); break; }

                    }
                    #endregion
                    else    // условие строка 19 не выполнено, вывод сообщения об ошибке, с дальнеёшим выходом из цикла строка 10
                    {
                        Console.Clear();
                        Console.WriteLine("Ошибка...");
                        Console.ReadKey();
                        break;      //выходов из цикла строка 10
                    }
                 
                }
                else    // строка != столбцу
                {
                    Console.WriteLine("Строки и столбцы должны совпалать!!!");
                    Console.ReadKey();
                    continue; // возвращение в начало цикла строка 10 
                }

            }
        }
    }
}
