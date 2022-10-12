Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
    if (username.ToLower() == "alex")
    {
        Console.WriteLine("Здоров, Бро!");
    }
    else
    {
        Console.Write("Привет, ");
        Console.Write(username);
    }
