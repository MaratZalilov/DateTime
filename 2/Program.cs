void Menu()
{
    Console.WriteLine("Выберите товар для его покупки");
    Console.WriteLine();
    Console.WriteLine("1. Принтер");
    Console.WriteLine("2. Системный блок");
    Console.WriteLine("3. Телевизор");
}
void GetMenu()
{
    string select = Console.ReadLine();
    bool parse = int.TryParse(select, out var menu);
    if (parse)
    {
        switch (menu)
        {
            case 1:
                var datePrinter = DateTime.Now;
                var datePrinter1 = datePrinter.AddDays(7);
                Console.WriteLine();
                Console.WriteLine($"Ваш товар будет доставлен {datePrinter1.ToLongDateString()}");
                Console.WriteLine();
                break;

            case 2:
                var dateSystem = DateTime.Now;
                var dateSystem1 = dateSystem.AddMonths(2);
                Console.WriteLine();
                Console.WriteLine($"Ваш товар будет доставлен {dateSystem1.ToLongDateString()}");
                Console.WriteLine();
                break;

            case 3:
                var dateTV = DateTime.Now;
                var dateTV1 = dateTV.AddYears(100);
                Console.WriteLine();
                Console.WriteLine($"Ваш товар будет доставлен {dateTV1.ToLongDateString()}");
                Console.WriteLine();
                break;

            default:
                Console.WriteLine();
                Console.WriteLine("Ошибка");
                Console.WriteLine();
                string path = @"C:\Users\Студент1\Desktop\log.txt";
                FileInfo log = new FileInfo(path);
                if (log.Exists)
                {
                    using (StreamWriter writeLog = new StreamWriter(path, true))
                    {
                        writeLog.WriteLine("Ошибка, введите корректное значение в меню");
                        writeLog.WriteLine();
                    }
                }
                else
                {
                    using (log.Create())
                    {

                    }
                    using (StreamWriter writeLog = new StreamWriter(path, true))
                    {
                        writeLog.WriteLine("Ошибка, введите корректное значение в меню");
                        writeLog.WriteLine();
                    }
                }
                break;
        }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Ошибка");
        Console.WriteLine();
        string path = @"C:\Users\Студент1\Desktop\log.txt";
        FileInfo log = new FileInfo(path);
        if (log.Exists)
        {
            using (StreamWriter writeLog = new StreamWriter(path, true))
            {
                writeLog.WriteLine("Ошибка, введите корректное значение в меню");
                writeLog.WriteLine();
            }
        }
        else
        {
            using (log.Create())
            {

            }
            using (StreamWriter writeLog = new StreamWriter(path, true))
            {
                writeLog.WriteLine("Ошибка, введите корректное значение в меню");
                writeLog.WriteLine();
            }
        }
    }
}
while (true)
{
    Menu();
    GetMenu();
}