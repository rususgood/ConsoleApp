using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ставку (5–100, шаг 5): ");
        int bet = int.Parse(Console.ReadLine());

        if (bet < 5 || bet > 100 || bet % 5 != 0)
        {
            Console.WriteLine("Неверная ставка");
            return;
        }

        Random rnd = new Random();

        int a = rnd.Next(1, 10);
        int b = rnd.Next(1, 10);
        int c = rnd.Next(1, 10);

        Console.WriteLine($"{a} {b} {c}");

        double coef = 0;

        if (a == b && b == c)
        {
            if (a == 7) coef = 150 * 1.5;
            else coef = a * 10 * 1.5;
        }
        else if (a == b || b == c)
        {
            int pair = a == b ? a : b;
            if (pair == 7) coef = 15 * 1.25;
            else coef = pair * 1.25;
        }
        else if (a == 7 || b == 7 || c == 7)
        {
            coef = 1.6;
        }
        else if (a == 9 || b == 9 || c == 9)
        {
            coef = 1.35;
        }

        if (coef == 0)
        {
            Console.WriteLine("Проигрыш");
        }
        else
        {
            double win = bet * coef;
            Console.WriteLine($"Вы выиграли {win}$");
        }
    }
}
