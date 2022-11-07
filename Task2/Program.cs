class Task2
{
    public static void Main()
    {
        Console.WriteLine("Введите число:");
        int userNumber = Convert.ToInt32(Console.ReadLine());

        // Перше рішення

        if((userNumber & 1) == 0)
        {
            Console.WriteLine("Четное число");
        } else
        {
            Console.WriteLine("Нечетное число");
        }

        // Друге рішення

        if (userNumber % 2 == 0)
        {
            Console.WriteLine("Четное число");
        } 
        else
        {
            Console.WriteLine("Нечетное число");
        }

        Console.ReadKey();
    }


}