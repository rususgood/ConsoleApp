using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите ваше возраст:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите ваш рост в метрах:");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Есть ли у вас Vip-Билет?");
        string vipInput = Console.ReadLine();

        int heightInCm = (int)(height * 100);

        if (age < 0 || height < 0)
        {
            Console.WriteLine("Ошибка: данные введены неверно.");
        }
        else
        {
            if ((age >= 14 && height > 150) || (vipInput == "да" && height >= 140))
            {
                Console.WriteLine("Проход разрешен!");
            }
            else
            {
                Console.WriteLine("Доступ запрещен.");
            }
        }
    }
}
