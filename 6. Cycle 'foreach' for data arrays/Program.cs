using System;
using System.Collections.Generic; // підключення нової для нас бібліотеки яка дозволяє використовувати колекції
using System.Runtime.CompilerServices; 

namespace Foreach; // простір імен
class Program
// цикл foreach використовується для перебору елементів масиву
{
    static void Main()
    {
        string[] names = { "John", "Paul", "George", "Ringo" }; // створення масиву з іменами
        char letter = 'G';                                      // створення змінної з буквою для подайльної перевірки

        Console.WriteLine($"Words containing '{letter}':");
        foreach (var word in names)                             // для кожного слова в масиві names
        {                                                       // якщо слово містить букву letter, то виводить його на екран
            if (word.Contains(letter))
            {
                Console.WriteLine(word);
            }
        }
            int[,] nums =
        {
            {1, 2, 3, },
            {4, 5, 6, },
            {7, 8, 9, }
        };
        foreach (int i in nums) // для кожного елемента масиву nums виводить його на екран
        {
            if (i % 2 == 0) // якщо число парне, то виводить його на екран
            Console.WriteLine(i);
        }

        List<int> numbers = new List<int> {1 }; // створення нового списку після знаку = виділяється пам'ять для списку
        numbers.Add(2); // додаємо елементи в список
        numbers.Remove(2); // видаляємо елемент зі списку
        numbers.Reverse(); // реверсуємо список
        // в цілому список можна розглядати як масив, але він має більше можливостей
        // він потребує більше пам'яті, але він дозволяє змінювати масив "на льоту"
        // також він має додаткові методи, які дозволяють змінювати його. Вище були наведені деякі з них

    }
}