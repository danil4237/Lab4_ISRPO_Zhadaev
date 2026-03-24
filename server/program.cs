using   System;

Console.WriteLine("Здравствуйте");
Console.WriteLine("Жадаев Данил");
Conwole.WriteLine("ИСП-232");
Conwole.WriteLine($"Дата и время: {DateTime.Now}");

string? choice;

do
{
    Console.WriteLine("\n=== Меню ===");
    Console.WriteLine("1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");
    Console.Write("Выберите пункт: ");

    choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Жадаев Данил");
            break;
        case "2":
            Console.WriteLine("ИСП-232");
            break;
        case "3":
            Console.WriteLine(DateTime.Now);
            break;
        case "4":
            Console.WriteLine("Выход из программы...");
            break;
        default:
            Console.WriteLine("Неверный выбор");
            break;
    }
} while (choice !="4");