using System;
using System.Threading.Tasks;
using System.Threading;

//HomeWork 9 C#
//Developer by kipov.m.h
//6.09.2022

namespace HomeWork2
{
    class Program
    {
        ////////////Глобальные переменные////////////////
        public const string VerDev = "V.0.2.2";
        //////Номер задания//////
        public const string NamberWork = "Home work 9";
        //////Название программ///////
        public const string ProgramName_1 = "Программа принимает на вход 2 значения M и N. Потом выводит все натуральные числа в промежутке от M до N.";
        public const string ProgramName_2 = "Программа принимает на вход 2 значения M и N. Программа найдёт сумму натуральных элементов в промежутке от M до N.";
        public const string ProgramName_3 = "Программа вычисляет функцию Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N.";
        public const string ProgramName_4 = "Null";
        public const string ProgramName_5 = "Null";
        //////////////////////////////
        public static bool LoadScrin = true;
        //public static int DownNum = 0;
        //public static int AcermanNum = 0;
        ///////
        
        //////////////////////////////////////////////// Вывод натуральных чисел рекурсия//////////////////////////////////////////////////////

        static void PrintNumNat(int[] arrayUser, int i)
        {
            if (i < arrayUser[1])
            {
                if (i>0) { Console.Write($"{i},"); }
                i++;
                PrintNumNat(arrayUser, i);
            } 
            else if (i == arrayUser[1])
            {
                Console.Write($"{i}.\n");
            }
        }

        //////////////////////////////////////////////// Вывод суммы натуральных чисел рекурсия//////////////////////////////////////////////////////

        static void PrintNumSum(int[] arrayUser, int i, int j)
        {
            if (j < arrayUser[1])
            {
                j++;
                i = i + j;
                PrintNumSum(arrayUser, i, j);
            }
            else if (j == arrayUser[1])
            {
                Console.Write($"Сумма: {i}.\n");
            }
        }
        //////////////////////////////////////////////// Вывод вычислений функции Аккермана рекурсия//////////////////////////////////////////////////////

       static int PrintNumAcerman(int n, int m)
        {
            if (n == 0)           { return m + 1; }
            if (n != 0 && m == 0) { return PrintNumAcerman(n - 1, 1); }
            if (n > 0  && m >  0) { return PrintNumAcerman(n - 1, PrintNumAcerman(n, m - 1)); }

            return PrintNumAcerman(n, m);
        }
        ///////////////////////////////////////// Промежуточное меню для выхода или продолжнеия программы /////////////////////////////
        static void Contin()
        {
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.Write("\nНажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Enter ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы начать.");

            Console.Write("Нажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.\n");
            Console.ResetColor();
        }
        //////////////////////////////////// Выход из программы по нажатию кнопок /////////////////////////////////////////////////////
        static int textWrite(int Exit_Play, string NameProg)
        {
            Contin();

            while (true)
            {
                var Presskey = Convert.ToString(Console.ReadKey().Key);
                if (Presskey == "q0" || Presskey == "End" || Presskey == "Backspace" || Presskey == "Escape" || Presskey == "Q1" || Presskey == "Q" || Presskey == "q")
                {
                    return 0;
                }
                else if (Presskey == "Enter" || Presskey == "Spacebar")
                {
                    return 1;
                }
                else
                {
                    devWrite(NameProg);
                    Contin();
                    return 3;
                }
            }
        }
        ///////////////////////////////// Очистка экрана и вывод redkipov. ////////////////////////////////////////////////////////////
        static void devWrite(string s)
        {

            Console.Clear();
            const String nameDev = "redkipov";
            Console.ForegroundColor = ConsoleColor.Cyan; // цвет 
            Console.Write("developer - ");
            Console.ForegroundColor = ConsoleColor.DarkRed; // цвет 
            Console.WriteLine(nameDev);
            Console.ForegroundColor = ConsoleColor.DarkGray; // цвет 
            Console.WriteLine(VerDev);
            Console.ForegroundColor = ConsoleColor.Yellow; // цвет 
            Console.WriteLine(s);
            Console.ResetColor();




        }
        /////////////////////////////////////////////////// Меню приветствия //////////////////////////////////////////////////////////
        //___________________________________________________________________________________________________________________________//
        static void WelcomeWrite(string NameProg)
        {
            devWrite(NameProg);
            Console.ForegroundColor = ConsoleColor.DarkCyan; //  цвет
            Console.WriteLine(NamberWork);
            Console.ForegroundColor = ConsoleColor.Green; //  цвет зеленый
            Console.Write("Введите соотвествующую цифру программы, которую вы хотите ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta; //  цвет
            Console.WriteLine("запустить");
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[1] "); ////// Первая программа.
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_1);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[2] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_2);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[3] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_3); /*
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[4] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_4);
            Console.ForegroundColor = ConsoleColor.Blue;   // синий цвет
            Console.Write("[5] ");
            Console.ForegroundColor = ConsoleColor.Yellow; // желтый цвет
            Console.WriteLine(ProgramName_5); */
            ///////////////////////////////////////////////////////////
            Console.Write("\nНажмите - ");
            Console.ForegroundColor = ConsoleColor.Blue; // синий цвет
            Console.Write("Q, End, Escape ");
            Console.ForegroundColor = ConsoleColor.Green; // зеленый цвет
            Console.WriteLine("чтобы выйти.");
            Console.ResetColor(); // сбрасываем в стандартный
        }
        //############################################### Программа 1 ###############################################################//
        //###########################################################################################################################//
        static void Program_1(int Exit_Play)
        {
            ///////////переменные
            int[] arrayUser = new int[2];
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[1] {ProgramName_1}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica (((((((((((((((((  
                Console.WriteLine("(M не может быть больше N. Число N не больше 9000) ");
                Console.WriteLine("Введите первое число М: ");
                arrayUser[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число N: ");
                arrayUser[1] = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                if (arrayUser[0] > arrayUser[1])
                {
                    Console.WriteLine($"Ваши числа: M:{arrayUser[0]} N:{arrayUser[1]}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Начальное число M больше конечной N");
                }
                else if (arrayUser[1] > 9000)
                {
                    Console.WriteLine($"Ваши числа: M:{arrayUser[0]} N:{arrayUser[1]}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Число N превышает 9000. Вычисление не может быть выполнено, так как это может привести к переполнению стека.");
                }
                else
                {
                    Console.WriteLine($"Ваши числа: M:{arrayUser[0]} N:{arrayUser[1]}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintNumNat(arrayUser, arrayUser[0]);
                }

                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 2 ###############################################################//
        //###########################################################################################################################//
        static void Program_2(int Exit_Play)
        {
            ///////////переменные
            int[] arrayUser = new int[2];
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[2] {ProgramName_2}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica (((((((((((((((((  
                Console.WriteLine("(M не может быть больше N. Число N не больше 10000) ");
                Console.WriteLine("Введите первое число М: ");
                arrayUser[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число N: ");
                arrayUser[1] = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                if (arrayUser[0] > arrayUser[1])
                {
                    Console.WriteLine($"Ваши числа: M:{arrayUser[0]} N:{arrayUser[1]}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Начальное число M больше конечной N");
                }
                else if (arrayUser[1] > 10000)
                {
                    Console.WriteLine($"Ваши числа: M:{arrayUser[0]} N:{arrayUser[1]}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Число N превышает 10000. Вычисление не может быть выполнено, так как это может привести к переполнению стека.");
                }
                else
                {
                    Console.WriteLine($"Ваши числа: M:{arrayUser[0]} N:{arrayUser[1]}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    PrintNumSum(arrayUser, arrayUser[0], arrayUser[0]);
                }

                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //############################################### Программа 3 ###############################################################//
        //###########################################################################################################################//
        static void Program_3(int Exit_Play)
        {
            ///////////переменные
            int[] arrayUser = new int[2];
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = $"[3] {ProgramName_3}";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                Console.ResetColor();
                //))))))))))))))))) Logica (((((((((((((((((  
                Console.WriteLine("(Число N и M не должно быть больше 3) ");
                Console.WriteLine("Введите первое число М: ");
                arrayUser[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число N: ");
                arrayUser[1] = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                devWrite(NameProg);
                Console.WriteLine("Результат работы: ");
                if (arrayUser[1] > 3 || arrayUser[0] > 3)
                {
                    Console.WriteLine($"Ваши числа: M:{arrayUser[0]} N:{arrayUser[1]}");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Число N превышает 10000. Вычисление не может быть выполнено, так как это может привести к переполнению стека.");
                }
                else
                {
                    Console.WriteLine($"Ваши числа: M:{arrayUser[0]} N:{arrayUser[1]}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Результат вычисления:{PrintNumAcerman(arrayUser[0],arrayUser[1])}.");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        
        }
        //############################################### Программа скрытая #########################################################//
        //###########################################################################################################################//
        static void Program_7(int Exit_Play)
        {
            ////////// Вывод меню и отслеживание нажатия кнопки для начала//////////////
            string NameProg = "Скрытое меню";
            devWrite(NameProg);
            Exit_Play = textWrite(Exit_Play, NameProg);
            while (Exit_Play == 1)
            {
                while (Exit_Play == 3)
                {
                    devWrite(NameProg);
                    Exit_Play = textWrite(Exit_Play, NameProg);
                }
                devWrite(NameProg);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(" ");
                Console.ResetColor();
                ////////**************** Logica **************////////
                

                ////////**************** End Logica **************////////
                Exit_Play = textWrite(Exit_Play, NameProg);
            }
        }
        //******************************************************** MAIN *********************************************************************//
        //###################################################################################################################################//

        static void Main(string[] args)
        {
            var PresskeyP = "Null";
            const String NameProg = "Главное меню";
            int Exit_Play = 1;
            WriteMenu(NameProg);
            while (true)
            {
                /////////////////////////////////////////// Ожидание нажатия кнопки //////////////////////////////////////////
                try
                {
                    PresskeyP = Convert.ToString(Console.ReadKey().Key);
                    //////////////////////////////////// Выбор пункта меню, нужной программы /////////////////////////////////////
                    if (PresskeyP == "D1" || PresskeyP == "NumPad1")
                    {
                        LoadScrin = false;
                        //Console.CursorVisible = true;
                        Program_1(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);
                    }
                    else if (PresskeyP == "D2" || PresskeyP == "NumPad2")
                    {
                        LoadScrin = false;
                        Console.CursorVisible = true;
                        Program_2(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);
                    }
                    else if (PresskeyP == "D3" || PresskeyP == "NumPad3")
                    {
                        LoadScrin = false;
                        //Console.CursorVisible = true;
                        Program_3(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);
                    }
                    else if (PresskeyP == "D4" || PresskeyP == "NumPad4")
                    { /*
                        LoadScrin = false;
                        Console.CursorVisible = true;
                        Program_4(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg); */
                    }
                    else if (PresskeyP == "D5" || PresskeyP == "NumPad5")
                    { /*
                        LoadScrin = false;
                        Console.CursorVisible = true;
                        Program_5(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg); */
                    }
                    else if (PresskeyP == "D6" || PresskeyP == "NumPad6")
                    {
                        //Program_6(Exit_Play);
                    }
                    else if (PresskeyP == "D7" || PresskeyP == "NumPad7")
                    {
                        LoadScrin = false;
                        Console.CursorVisible = true;
                        Program_7(Exit_Play); //запуск функции
                        LoadScrin = true;
                        WriteMenu(NameProg);
                    }
                    else if (PresskeyP == "q0" || PresskeyP == "End" || PresskeyP == "Backspace" || PresskeyP == "Escape" || PresskeyP == "Q1" || PresskeyP == "Q" || PresskeyP == "q")
                    {
                        System.Environment.Exit(-1);
                        return;
                    }
                }
                catch
                {
                    Console.WriteLine("\nПроизошла ошибка...");
                    //PresskeyP = "Null";
                }
            }
        }


        static void WriteMenu(String NameProg)
        {
            WelcomeWrite(NameProg);
            Console.WriteLine(" ");
            Method();
        }

        ///// BETA
        static async void Method()
        {
            int k = 0;
            char[] LoadString = { '/', '/', '/', '/', '/', '/', '/', '/', '/', '/' };
            ///////////////////////////////////////////////// Task 1
            await Task.Run(() =>
            {
                //async
            });
            ///////////////////////////////////////////////// Task 2
            while (LoadScrin)
            {
                await Task.Delay(500);
                k++;
                if (LoadScrin)
                {
                    //await Task.Delay(950);
                    //Thread.Sleep(1000);
                    Console.Write($"                                                 \r");
                    try
                    {
                        Console.CursorVisible = false;
                        var Time = DateTime.Now;
                        Console.Write($"{Time}      ");
                    }
                    catch
                    {
                        var Time = DateTime.Now;
                        Console.Write($"{Time}      ");
                    }

                }
                else if (!LoadScrin) { return; }
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < k; i++) { Console.Write(LoadString[i]); if (k == LoadString.Length + 1) { k = 0; } }
                Console.ForegroundColor = ConsoleColor.White;
            }
            //await Task.Run(() => Program_7(1) );
        }
    }
    //######################################################## END ###############################################################//
}
//###########################################################################################################################//