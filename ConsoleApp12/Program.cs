        Console.WriteLine("Введите значение a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите значение b:");
        double b = Convert.ToDouble(Console.ReadLine());
        double z = Max(a, 2 * b) + Max(2 * a - b, b);
        Console.WriteLine($"Значение z: {z}");
    static double Max(double x, double y)
    {
        return (x > y) ? x : y;
    }
