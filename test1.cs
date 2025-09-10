using System;

Console.WriteLine("Выберите ID задания:\n[1] Перевод из системы в систему\n[2] Часики");
int Salami = Convert.ToInt32(Console.ReadLine());
switch (Salami)
{
    case 1:
        Console.WriteLine("Выберите ID необходимой операции:\n[1] Из двоичной в десятичную\n[2] Из десятичной в двоичную");
        string change = Console.ReadLine();
        if (change == "1")
        {
            Console.WriteLine("Введите двоичное число для перевода:");
            string NumberA = Console.ReadLine();
            int Res = Convert.ToInt32(NumberA, 2);
            Console.WriteLine("Ваш результат: " + Res);
        }
        else if (change == "2")
        {
            Console.WriteLine("Введите десятичное число для перевода:");
            int NumberA = Convert.ToInt32(Console.ReadLine());
            string Res = Convert.ToString(NumberA, 2);
            Console.WriteLine("Ваш результат: " + Res);
        }
        else
        {
            Console.WriteLine("Неверный ID!\nДоступные операции:\n[1] Из двоичной в десятичную\n[2] Из десятичной в двоичную");
        }
        break;
    case 2:
        Console.WriteLine("Введите часы:");
        int Hours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите минуты:");
        int Minutes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите T (Время на доставочку в минутках):");
        int T = Convert.ToInt32(Console.ReadLine());
        int totalMinutes = Hours * 60 + Minutes;
        totalMinutes += T;
        totalMinutes %= 1440;
        int hours = totalMinutes / 60;
        int minutes = totalMinutes % 60;
        string fHours = hours.ToString("00");
        string fMinutes = minutes.ToString("00");
        Console.WriteLine($"{fHours}:{fMinutes}");
        break;
    default:
        Console.WriteLine("Неверный ID!\nДоступные задания:\n[1] Перевод из системы в систему\n[2] Часики");
        break;
}
