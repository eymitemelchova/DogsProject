using System;

class HanoiTowers
{
    // Рекурсивна функция за решаване на задачата
    static void SolveHanoi(int n, char fromRod, char toRod, char auxRod)
    {
        // Базов случай: ако има само един диск
        if (n == 1)
        {
            Console.WriteLine($"Премести диск 1 от {fromRod} на {toRod}");
            return;
        }

        // Преместване на n-1 диска от fromRod на auxRod, като използваме toRod като помощен стълб
        SolveHanoi(n - 1, fromRod, auxRod, toRod);

        // Преместване на най-големия диск от fromRod на toRod
        Console.WriteLine($"Премести диск {n} от {fromRod} на {toRod}");

        // Преместване на n-1 диска от auxRod на toRod, като използваме fromRod като помощен стълб
        SolveHanoi(n - 1, auxRod, toRod, fromRod);
    }

    static void Main()
    {
        int n;  // Броят на дисковете
        Console.Write("Въведете броя на дисковете: ");
        n = int.Parse(Console.ReadLine());

        // Стартиране на решението от стълб 1 към стълб 3 с помощта на стълб 2
        SolveHanoi(n, '1', '3', '2');
    }
}

