namespace Task23
{
    //ЗАДАЧА 23: на входе натуральное число N, а на выходе список кубов чисел от 1 до N включительно.
    public class DZ
    {
        public void Start()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ЗАДАЧА 23: на входе натуральное число N, а на выходе список кубов чисел от 1 до N включительно.");
            Console.ResetColor();


            string rezult = ""; // для результата
            double n = InputN(); //ввод числа

            for (double i = 1; i <= n; i++)
            {
                if (i > 1) rezult += "; ";        
                rezult += "[" + i + "]=[" + Math.Pow(i, 3) + "]";
            }


            Console.WriteLine("");
            Console.WriteLine("Результат (число = куб числа): " + rezult); //вуаля

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("* для завершения задачи нажмите любую клавишу...");
            Console.ResetColor();
            Console.ReadKey(true);
        }






        // Функция ввода и проверки числа N
        double InputN()
        {
            int rezult = 0; // число N
            string str = ""; //вводимые данные
            bool check = false; // метка успешной проверки.
            Console.WriteLine("");
            do
            {
                Console.ResetColor();
                Console.Write("Введите число N: ");

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

                if (rezult < 1) // проверка на натуральность
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("err: число должно быть натуральным!");

                    continue;
                }                

                check = true; // проверка прошла успешно
            } while (check == false);
            return Convert.ToDouble(rezult);
        }
    }




    //На случай запуска Task23.cs как самостоятельно проекта, не из под Главного Меню
    class Program
    {
        static void Main()
        {
            DZ dz = new DZ();
            dz.Start();
        }
    }
}