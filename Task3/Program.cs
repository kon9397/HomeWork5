class Task3
{
    public static void Main()
    {
        int x = 5, y = 10, z = 15;

        x += y >> x++ * z; // 5
        z = ++x & y * 5; // 2
        y /= x + 5 | z; // 0
        z = x++ & y * 5; // 0
        x = y << x++ ^ z; // 0

        Console.WriteLine("x: " + x);
        Console.WriteLine("y: " + y);
        Console.WriteLine("z: " + z);

        Console.ReadKey();
    }
}