using System;

class Program
{
    static void Main()
    {
        /*
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
        */


        Console.Write("Сумма заказа (грн): ");
        int orderSum = int.Parse(Console.ReadLine());

        Console.Write("Расстояние (км, например 5,5): ");
        double distance = double.Parse(Console.ReadLine());

        Console.Write("Есть купон на бесплатную доставку? (да/нет): ");
        string answer = Console.ReadLine().ToLower();
        bool hasCoupon = (answer == "да");

        if (orderSum < 0 || distance < 0)
        {
            Console.WriteLine("Ошибка: данные не могут быть отрицательными.");
        }
        else
        {
            int deliveryCost = (int)(distance * 15.5);

            bool isFree = (orderSum > 400 && distance < 5) || (hasCoupon && distance < 10);

            if (isFree)
            {
                deliveryCost = 0;
                Console.WriteLine("Доставка бесплатная!");
            }
            else
            {
                Console.WriteLine("Стоимость доставки: " + deliveryCost + " грн.");
            }

            int finalSum = orderSum + deliveryCost;
            Console.WriteLine("Итого к оплате: " + finalSum + " грн.");
        }
}
}
