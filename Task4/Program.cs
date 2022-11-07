class Task4
{
    public static void Main()
    {
        Console.WriteLine("Введите имя работника");
        string employerName = Console.ReadLine();
        if (employerName == "")
        {
            Console.WriteLine("Введите имя!!! Закройте консоль и начните еще раз");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Введите зарплату сотрудника с именем " + employerName);

        double salary = Convert.ToDouble(Console.ReadLine());

        if (salary == 0)
        {
            Console.WriteLine("Рабство запрещено! Закройте консоль и начните еще раз");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Введите стаж");
        double experience = Convert.ToDouble(Console.ReadLine());
        int premiumPercent = 0;
        if (experience < 5) 
        {
            premiumPercent = 10;
        } 
        else if (experience >= 5 && experience < 10)
        {
            premiumPercent = 15;
        }
        else if (experience >= 10 && experience < 15)
        {
            premiumPercent = 25;
        }
        else if (experience >= 15 && experience < 20)
        {
            premiumPercent = 35;
        }
        else if (experience >= 20 && experience < 25)
        {
            premiumPercent = 45;
        }
        else
        {
            premiumPercent = 50;
        }

        double premium = premiumPercent * salary / 100;

        Console.WriteLine("Имя: " + employerName);
        Console.WriteLine("Зарплата: " + salary);
        Console.WriteLine("Премия: " + premium);
    }
}