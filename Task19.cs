namespace Task19
{
    //ЗАДАЧА 19: на входе пятизначное натуральное число, а на выходе информация является ли оно палиндромом.
    public class DZ
    {       
        public void Start() // === START ===
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ЗАДАЧА 19: на входе пятизначное натуральное число, а на выходе информация является ли оно палиндромом.");
            Console.ResetColor();

            int a = InputA(); //ввод числа 
                        
            List<int> al = new List<int>(IntToList(a)); // разбор числа на разряды

            bool palindrom = true; // метка палиндрома

            if (al.Count > 1) // условие актуально для ДОП задачи, сюда же просто скопировано
            {
                for (int i = 0; i <= al.Count / 2 - 1; i++) // цикл до половины разрядов.
                {
                    if (al[i] != al[al.Count - 1 - i]) { palindrom = false; break; } // сравнение "зеркальных" разрядов
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Результат: " + ((palindrom == true) ? "" : "не ") + "палиндром."); // вуаля. и никаких строк =)

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("* для завершения задачи нажмите любую клавишу...");
            Console.ResetColor();
            Console.ReadKey(true);
        } // === FINISH ===





        // Функция ввода и проверки числа
        int InputA()
        {
            int rezult = 0; // число А
            string str = ""; //вводимые данные
            bool check = false; // метка успешной проверки.
            Console.WriteLine("");
            do
            {
                Console.ResetColor();
                Console.Write("Введите число: ");

                str = Console.ReadLine()!.Trim();

                if (str == "") // проверка на пустое тыканье Enter
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: серьезно? пустой ввод!");

                    continue;
                }

                if (int.TryParse(str, out rezult) == false) // проверка на соответствие типу integer
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: несоответствие типу integer!");

                    continue;
                }

                rezult = int.Parse(str); // преобразование в Integer

                if (rezult < 1) // проверка на значение
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: число должно быть натуральным!");

                    continue;
                }
                if (rezult < 10000 || rezult > 99999) // проверка на разрядность
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: число должно быть пятизначным!");

                    continue;
                }

                check = true; // проверка прошла успешно
            } while (check == false);
            return rezult;
        }

        // Функция записи int в List по разрядам
        List<int> IntToList(int number)
        {
            number = (int)Math.Abs(number);
            List<int> temp = new List<int>();
            List<int> rezult = new List<int>();
            while (number > 9)
            {
                temp.Add(number % 10);
                number /= 10;
            }
            rezult.Add(number);
            for (int i = temp.Count - 1; i > -1; i--)
            {
                rezult.Add(temp[i]);
            }
            return rezult;
        }
    }







    //На случай запуска Task19.cs как самостоятельно проекта, не из под Главного Меню
    class Program
    {
        static void Main()
        {
            DZ dz = new DZ();
            dz.Start();
        }
    }
}