class Task6
{
    public static void Main()
    {
        Console.WriteLine("Введите число");
        int n = Convert.ToInt32(Console.ReadLine());

        if(n > 0 && (n & (n - 1)) == 0)
        {
            Console.WriteLine($"Число {n} является степенью двойки");
        } 
        else
        {
            Console.WriteLine($"Число {n} не является степенью двойки");
        }

        Console.ReadKey();
    }

}