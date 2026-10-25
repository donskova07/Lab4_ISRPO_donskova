Console.WriteLine("Добро пожаловать");
Console.WriteLine("Донскова Ульяна Сергеевна");
Console.WriteLine("Группа: ИСП-242");
Console.WriteLine("Текущие дата и время: 25.10.2026");

while (true){
    Console.WriteLine("Меню:");
    Console.WriteLine("1 — Показать ФИО");
    Console.WriteLine("2 — Показать группу");
    Console.WriteLine("3 — Показать дату");
    Console.WriteLine("4 — Выход");
    Console.Write("Выберите пункт меню: ");
    string choice = Console.ReadLine();
    switch (choice){
        case "1":
            Console.WriteLine("ФИО: Донскова Ульяна Сергеевна");
            break;
        case "2":
            Console.WriteLine("Группа: ИСП-242");
            break;
        case "3":
            Console.WriteLine("Текущая дата: 25.10.2026");
            break;
        case "4":
            Console.WriteLine("Выход");
            return;
        default:
            Console.WriteLine("Такого выбора нет");
            break;
}
}