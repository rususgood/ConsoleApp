internal class Program
{
    static void Main(string[] args)
    {
        // Обложка
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║         📝 МОЯ АНКЕТА        ║");
        Console.WriteLine("╚══════════════════════════════╝");
        Console.WriteLine();

        // Ввод данных
        Console.Write("Имя: ");
        string name = Console.ReadLine();

        Console.Write("Фамилия: ");
        string surname = Console.ReadLine();

        Console.Write("Год рождения: ");
        int year = int.Parse(Console.ReadLine());

        Console.Write("Средний балл: ");
        double grade = double.Parse(Console.ReadLine());

        Console.Write("Пол (М/Ж): ");
        char gender = char.Parse(Console.ReadLine());

        // Построение рамки
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║         📋 ВАША АНКЕТА       ║");
        Console.WriteLine("╠══════════════════════════════╣");

        // Формат: "║ Название поля : значение      ║"
        Console.WriteLine($"║ Имя           : {name.PadRight(18)} ║");
        Console.WriteLine($"║ Фамилия       : {surname.PadRight(18)} ║");
        Console.WriteLine($"║ Год рождения  : {year.ToString().PadRight(18)} ║");
        Console.WriteLine($"║ Средний балл  : {grade.ToString().PadRight(18)} ║");
        Console.WriteLine($"║ Пол           : {gender.ToString().PadRight(18)} ║");

        Console.WriteLine("╚══════════════════════════════╝");

        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();


    }
}
