class Task7 {
    public static void Main()
    {
        bool A = true;
        bool B = false;

        // Выражение A | B
        if(A | B)
        {
            Console.WriteLine("A | B = " + (A | B));
        } else
        {
            Console.WriteLine("A | B = " + (A | B));
        }

        // Теорема Де Моргана

        if(!(!A & !B))
        {
            Console.WriteLine("!(!A & !B) = " + (A | B));
        } else
        {
            Console.WriteLine("!(!A & !B) = " + (A | B));
        }

        Console.ReadKey();
    }
}
