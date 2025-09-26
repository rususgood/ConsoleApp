using System;

class Program
{
    static void Main()
    {

        Console.Write("Введите название команды: ");
        string team = Console.ReadLine();

        Console.Write("Введите игровой никнейм: ");
        string nickname = Console.ReadLine();

        Console.Write("Введите уровень персонажа (число): ");
        int level = int.Parse(Console.ReadLine());

        Console.Write("Введите пол участника (м/ж): ");
        char gender = char.Parse(Console.ReadLine());

        Console.Write("Введите ставку за матч (грн): ");
        decimal bet = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\n===== АНКЕТА УЧАСТНИКА =====");
        Console.WriteLine("Название команды: " + team);
        Console.WriteLine("Игровой никнейм: " + nickname);
        Console.WriteLine("Уровень персонажа: " + level);
        Console.WriteLine("Пол участника: " + gender);
        Console.WriteLine("Ставка за матч: " + bet + " ₴");
        Console.WriteLine("============================");
    }
}
