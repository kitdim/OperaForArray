using System;

namespace SkillBox4._3
{
    class Program
    {
        /// <summary>
        /// Заполнение массива случайными числами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int[,] FillArray(int a, int b)
        {
            Random rdn = new Random();
            int[,] ar = new int[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    ar[i, j] = rdn.Next(10);
                }
            }
            return ar;
        }

        /// <summary>
        ///  Вывод массива
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static void OutputArray(int [,] ar, int a, int b)
        {

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write($"\t{ar[i, j]} ");
                }
                Console.WriteLine();
            }
            
        }

        /// <summary>
        /// Вывод произведения массива на число
        /// </summary>
        /// <param name="args"></param>
        public static void OutputArray(int[,] array, int a, int b, int number)
        {

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    array[i, j] *= number;
                    Console.Write($"\t{array[i, j]}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывод суммы массивов
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayTwo"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void OutputArray(int[,] arrayOne, int[,] arrayTwo, int a, int b)
        {
            int[,] sum = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    sum[i, j] = arrayOne[i, j] + arrayTwo[i, j];
                    Console.Write($"\t{sum[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывод разности массивов
        /// </summary>
        /// <param name="arrayOne"></param>
        /// <param name="arrayTwo"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void OutputArrayMinus(int[,] arrayOne, int[,] arrayTwo, int a, int b)
        {
            int[,] minus = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    minus[i, j] = arrayOne[i, j] - arrayTwo[i, j];
                    Console.Write($"\t{minus[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Вывод произведения массива
        /// </summary>
        /// <param name="arrayOne"></param>
        /// <param name="arrayTwo"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void OutputArrayMulti(int[,] arrayOne, int[,] arrayTwo, int a, int b)
        {
            int[,] multi = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    multi[i, j] = arrayOne[i, j] * arrayTwo[i, j];
                    Console.Write($"\t{multi[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Ввод
        /// </summary>
        /// <returns></returns>
        public static int Input()
        {
            int a = int.Parse(Console.ReadLine()); return a;
        }

        /// <summary>
        /// Ввод строки
        /// </summary>
        /// <returns></returns>
        public static string InputStr()
        {
            string a = Console.ReadLine(); return a;
        }

        /// <summary>
        /// Очистка консоли
        /// </summary>
        /// <param name="args"></param>
        /// 
        public static void Clear()
        {
            Console.Clear();
        }
        
        /// <summary>
        /// Вывод линии снизу
        /// </summary>
        public static void Line()
        {
            Console.WriteLine("\t_________________");
        }

        /// <summary>
        /// Вывод линии снизу и числа для умножения
        /// </summary>
        /// <param name="args"></param>
        public static void Line(int a)
        {
            Console.WriteLine($"\n\t\t      * {a}" +                 
                            "\n\t__________________");
        }

        /// <summary>
        /// Вывод случайной ошибки
        /// </summary>
        /// <param name="args"></param>
        public static void Error()
        {
            Random random = new Random();
            var rnd = random.Next(1, 4);
            switch (rnd) 
            {
                case 1:
                    Console.WriteLine("Упс..."); break;
                case 2:
                    Console.WriteLine("Ошибка...."); break;
                case 3:
                    Console.WriteLine("Что-то пошло не так..."); break;
            }
        }

        /// <summary>
        /// Пауза
        /// </summary>
        /// <param name="args"></param>
        public static void Pause()
        {
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            while (true)                
            {
                Clear();
                Console.Write("Введите количество строк: "); var stroka = Input();        // ввод строк
                Console.Write("Введите количество столбцов: "); var stolbec = Input();    // ввод столбцов
                Clear();        
                if (stroka == stolbec)  // если строка = столбцу
                {
                    Console.Write("Какой тебе нужен пункт:1/2/3 ? "); var task = InputStr(); Clear();    // ввод в консоль нужного пункта, далее очистка консоли
                    #region Task 1 перемножить рандомно созданный массив на введенный с клавиатуры множитель 
                    if (task == "1")   
                    {
                        Console.Write("Введите число на которое хотите умножить: "); var number = Input();        // ввод множителя
                        int[,] arraySelection = FillArray(stroka, stolbec);

                        Clear();
                        OutputArray(arraySelection,stroka, stolbec);
                        Line(number);
                        OutputArray(arraySelection, stroka, stolbec, number);
                      

                        Console.Write("\nХочешь посмотреть другие пункты да/нет ? "); var otvet = InputStr();    // вывод ответа
                        if (otvet == "да") continue;        // условие на продолжения , есла да==продолжить
                        else if (otvet == "нет") break;    // выход  
                        else { Error(); Pause(); break; } // выход
                    }
                    #endregion
                    #region Task 2 Выполнить операцию разности или сложения
                    else if (task == "2")
                    {
                        int[,] OneArraySelection = FillArray(stroka, stolbec);// инициализация первого массива
                        int[,] TwoArraySelection = FillArray(stroka, stolbec); // инициализация второго массива
                        
                        Console.Write("Тебе нужна операция сложения или вычитания +/-? "); var PlusOrMinus = InputStr(); // ввод нужной операции
                        switch (PlusOrMinus) // конструкция где заполнются рандомными значениями 2 массива, далее на выбор операция сложения или вычитания, в последующем вывод массива значения
                        {
                            case "+": // выбор операции сложения
                            {
                                    OutputArray(OneArraySelection, stroka, stolbec);
                                    Console.WriteLine(PlusOrMinus);
                                    OutputArray(TwoArraySelection, stroka, stolbec);
                                    Line();
                                    OutputArray(OneArraySelection, TwoArraySelection, stroka, stolbec); break;
                            }
                            case "-": // выбор операции вычитания 
                            {
                                    OutputArray(OneArraySelection, stroka, stolbec);
                                    Console.WriteLine(PlusOrMinus);
                                    OutputArray(TwoArraySelection, stroka, stolbec);
                                    Line();
                                    OutputArrayMinus(OneArraySelection, TwoArraySelection, stroka, stolbec); break;
                            }
                            default: // значение введенное не определенно кейсом 
                                Error(); break; 
                        } 

                        Console.Write("\nХочешь посмотреть другие пункты да/нет ? "); var otvet = Console.ReadLine();
                        if (otvet == "да") continue;    
                        else if (otvet == "нет") break; 
                        else { Error(); Pause(); break; }  
                    }
                    #endregion
                    #region Task 3 Выполнить перемножения двух массивов 
                    else if (task == "3")   // если задача = 3
                    {
                        Clear();
                        int[,] OneArraySelection = FillArray(stroka,stolbec);
                        int[,] TwoArraySelection = FillArray(stroka, stolbec);

                        OutputArray(OneArraySelection, stroka, stolbec);
                        Console.WriteLine("*");
                        OutputArray(TwoArraySelection, stroka, stolbec);
                        Line();
                        OutputArrayMulti(OneArraySelection,TwoArraySelection, stroka, stolbec);

                        Console.Write("Хочешь посмотреть другие пункты да/нет ? "); var otvet = Console.ReadLine();
                        if (otvet == "да") continue;
                        else if (otvet == "нет") break;
                        else { Error(); Pause(); break; }

                    }
                    else
                    {
                        Clear();Error();Pause();break;
                    }
                    #endregion
                }
                else
                {
                    Console.WriteLine("Строки и столбцы должны совпалать!!!"); Pause(); continue;
                }

            }
        }
    }
}
