try
{
    // ГЛАВНОЕ МЕНЮ ДЗ 3
    PrintMainMenu();

    ConsoleKey ck;
    
    do
    {
        ck = Console.ReadKey(true).Key;
       
        if (ck == ConsoleKey.D1 || (ck) == ConsoleKey.NumPad1) // [1]
        {
            try
            {
                Task19.DZ dz = new Task19.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                ExceptionMessage(MenuItemName(1), e.Message);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D2 || (ck) == ConsoleKey.NumPad2) // [2]
        {
            try
            {
                Task19Hard.DZ dz = new Task19Hard.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                ExceptionMessage(MenuItemName(2), e.Message);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D3 || (ck) == ConsoleKey.NumPad3) // [3]
        {
            try
            {
                Task21.DZ dz = new Task21.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                ExceptionMessage(MenuItemName(3), e.Message);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D4 || (ck) == ConsoleKey.NumPad4) // [4]
        {
            try
            {
                Task21Hard.DZ dz = new Task21Hard.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                ExceptionMessage(MenuItemName(4), e.Message);
            }
            PrintMainMenu();
        }
        if (ck == ConsoleKey.D5 || (ck) == ConsoleKey.NumPad5) // [5]
        {
            try
            {
                Task23.DZ dz = new Task23.DZ();
                dz.Start();
            }
            catch (Exception e)
            {
                ExceptionMessage(MenuItemName(5), e.Message);
            }
            PrintMainMenu();
        }
    }
    while (ck != ConsoleKey.Q);
}
catch (Exception e)
{
    ExceptionMessage("Program.cs", e.Message);
}



// наименования пунктов меню
string MenuItemName(int number)
{
    if (number == 1) return "Задача № 19";
    if (number == 2) return "Задача № 19 HARD";
    if (number == 3) return "Задача № 21";
    if (number == 4) return "Задача № 21 HARD";
    if (number == 5) return "Задача № 23";
    else return "";
}

// отрисовка главного меню
void PrintMainMenu()
{
    Console.Clear();
    Console.ResetColor();
    Console.WriteLine("");
    Console.WriteLine("[1] - " + MenuItemName(1));
    Console.WriteLine("");
    Console.WriteLine("[2] - " + MenuItemName(2));
    Console.WriteLine("");
    Console.WriteLine("[3] - " + MenuItemName(3));
    Console.WriteLine("");
    Console.WriteLine("[4] - " + MenuItemName(4));
    Console.WriteLine("");
    Console.WriteLine("[5] - " + MenuItemName(5));
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("* инициируйте выполнение Задач клавишами [1] [2] [3] [4] [5] или нажмите [Q] для выхода из программы...");
    Console.ResetColor();
}

// вывод исключения
void ExceptionMessage(string taskName, string eMessage)
{
    Console.WriteLine("");
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Ошибка выполнения " + taskName + ": " + eMessage);
    Console.ResetColor();
    Console.WriteLine("");
    Console.Write("нажмите любую клавишу...");
    Console.ReadKey(true);
}
