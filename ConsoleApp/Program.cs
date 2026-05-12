using System;

class Program
{
    static void Main()
    {
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