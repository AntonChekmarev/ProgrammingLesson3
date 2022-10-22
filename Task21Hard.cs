namespace Task21Hard
{
    //ЗАДАЧА 21 HARD: на входе координаты двух точек в N-мерном пространстве, на выходе расстояние между ними.
    public class DZ
    {
        public void Start() // === START ===
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ЗАДАЧА 21 HARD: на входе координаты двух точек в N-мерном пространстве, на выходе расстояние между ними.");
            Console.ResetColor();

            int n; // мерность пространства
            List<double[]> spaceAll; // все координаты точек А и В
            double rezult; // расстояние между точками

            n = InputN(); // ввод мерности (число N)

            spaceAll = InputСoord(n); // ввод координат точек А и В

            double[] skobki = new double[n]; // подсчитанные значения всех скобок 
            for (int i = 0; i <= n -1; i++) 
            {
                double xa = spaceAll[0][i];
                double xb = spaceAll[1][i];

                skobki[i] = Math.Pow(xb - xa, 2); // (Xb - Xa)^2
            }

            double sum = 0; // сумма всех скобок
            for (int i = 0; i <= n - 1; i++) 
            {
                sum += skobki[i];
            }
                 
            rezult = Math.Sqrt(sum); // извлечение квадратного корня
            rezult = Math.Round(rezult, 2); // округление до двух знаков

            Console.WriteLine("");
            Console.WriteLine("Расстояние между точками: " + rezult);

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("* для завершения задачи нажмите любую клавишу...");
            Console.ResetColor();
            Console.ReadKey(true);

        }// === FINISH ===




     

        //функция ввода координат точек А и В
        List<double[]> InputСoord(int allSpace)
        {

            List<double[]> rezult = new List<double[]>();
            string str = "";

            Console.WriteLine("");            
            for (int i = 0; i <= 1; i++) // цикл по точкам А(0) и B(1)
            {
            Input:                              
                
                Console.ResetColor();                
                Console.Write("Введите " + ((allSpace > 1)?"(через запятую) ":"") + allSpace + " " + PaintText(allSpace) + " точки " + ((i == 0)?"A":"B") + ": ");

                str = Console.ReadLine()!.Trim();

                if (str == "") // проверка на пустое тыканье Enter
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: серьезно? пустой ввод!");

                    goto Input;
                }

                string[] str_ = str.Split(','); // разбив на элементы

                if (str_.Count() != allSpace) // проверка на соответствие кол-ва координат с мерностью пространства
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: неверное кол-во координат!");

                    goto Input;
                }
                double[] tempArray = new double[allSpace];
                for (int j = 0; j < str_.Length; j++) // цикл по координатам
                {
                    if (str_[j].Trim().IndexOf(" ") > -1) // пресекается возможность предоставляемая double.Parse(), скормить ввод пробелов внутрь числа (например "1 1" = "11"). В свою очередь int.Parse() такое себе не позволяет и это правильно.
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("err: некорректная запись числа!");

                        goto Input;
                    }
                    if (double.TryParse(str_[j], out double a) == true) // проверка на соответствие типу double
                    {
                        tempArray[j] = double.Parse(str_[j]); // запись координат
                    }
                    else // если координата НЕ является числом
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("err: несоответствие допустимому числовому типу!");

                        goto Input;
                    }
                }
                rezult.Add(tempArray);
            }      
            return rezult;
        }

        // Функция ввода и проверки числа N
        int InputN()
        {
            int rezult; // число N
            string str = ""; //вводимые данные
            bool check = false; // метка успешной проверки.
            Console.WriteLine("");
            do
            {
                Console.ResetColor();
                Console.Write("Введите мерность пространства (число N): ");
                if (int.TryParse(str = Console.ReadLine().Trim()!, out rezult) == false) // проверка на соответствие типу integer
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: несоответствие типу integer!");

                    continue;
                }

                rezult = int.Parse(str); // преобразование в Integer

                if (rezult < 1) // проверка на натуральность
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: число должно быть натуральным!");

                    continue;
                }

                check = true; // проверка прошла успешно
            } while (check == false);
            return rezult;
        }

        // Функция склонения слова "координаты" для контекста: "введите Х координат точки"
        string PaintText(int number)
        {
            number = (int)Math.Abs(number);
            int n;
            string rezult = "";

            n = number % 100;
            if (n >= 11 & n <= 14) rezult = "координат";
            else
            {
                n = number % 10;
                if (n == 1) rezult = "координату";
                else if (n >= 2 & n <= 4) rezult = "координаты";
                else rezult = "координат";
            }

            return rezult;
        }
    }







    //На случай запуска Task21Hard.cs как самостоятельно проекта, не из под Главного Меню
    class Program
    {
        static void Main()
        {
            DZ dz = new DZ();
            dz.Start();
        }
    }
}