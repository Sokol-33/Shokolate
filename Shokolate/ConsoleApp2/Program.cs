using System;

class Program
{
    static void Main(string[] args)
    {
        int money = 15;   // Имеющиеся деньги
        int price = 1;    // Цена за шоколадку
        int wrap = 3;     // Количество оберток для получения дополнительной шоколадки

        int chocolates = money / price;  // Количество шоколадок, которое можно купить за имеющиеся деньги
        int wrappers = chocolates;       // Изначально количество оберток равно количеству купленных шоколадок

        while (wrappers >= wrap)
        {
            int extraChocolates = wrappers / wrap;  // Количество дополнительных шоколадок, которые можно получить за обертки
            chocolates += extraChocolates;          // Увеличиваем общее количество шоколадок
            wrappers = wrappers % wrap + extraChocolates;  // Обновляем количество оставшихся оберток
        }

        Console.WriteLine($"Максимальное количество шоколадок: {chocolates}");
    }
}