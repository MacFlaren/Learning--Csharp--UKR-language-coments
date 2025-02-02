﻿using System;
// using System це простір імен, який містить класи, які надають базові функції, такі як робота з введенням/виведенням, робота з файлами, робота з мережею і т.д.
// вона потрібна для використання класів, які визначені в просторі імен System.
class program
// class program це клас, який містить метод Main метод це точка входу в програму. Точка входу в програму це місце, звідки починається виконання програми.
{
    static void Main()
    // static void Main() це метод, який викликається при запуску програми. Це викликається автоматично. static означає, що метод Main() є статичним,
    // тобто він викликається без створення об'єкта класу. main () це метод, який викликається при запуску програми.
    // метод це функція, яка виконує певну дію. void означає, що метод Main() не повертає значення.
    {
        int a, b, c;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        // є наступні математичні оператори в C#, такі як "+" це оператор додавання, "-" це оператор віднімання, "*" це оператор множення,
        // "/" це оператор ділення, "%" це оператор залишку, "++" це оператор інкремента, "--" це оператор декремента.
        // також є логічні оператори в C#, такі як "&&" це оператор І, "||" це оператор АБО, "!" це оператор НЕ.
        // функція math.pow() використовується для піднесення числа до степеня.
        // подібні до math.pow() є інші функції, такі як math.sqrt() для обчислення квадратного кореня, math.abs() для обчислення модуля числа
        c = a + b;
        Console.WriteLine("Sum is: " + c);
    }
}

//є різні типи даних в C#, такі як int, float, double, char, string, bool, long, short, byte, decimal, uint, ulong, ushort, sbyte.
//int - це цілочисельний тип даних, який займає 4 байти пам'яті. тобто він може зберігати значення від -2,147,483,648 до 2,147,483,647.
//float - це тип даних з плаваючою комою, який займає 4 байти пам'яті. тобто він може зберігати значення від 1.5 x 10^-45 до 3.4 x 10^38.
//double - це тип даних з плаваючою комою, який займає 8 байт пам'яті. тобто він може зберігати значення від 5.0 x 10^-324 до 1.7 x 10^308.
//char - це тип даних, який займає 2 байти пам'яті і використовується для зберігання одного символу. тобто він може зберігати значення від 0 до 65535.
//string - це тип даних, який використовується для зберігання послідовності символів. тобто він може зберігати будь-яку послідовність символів.
//bool - це тип даних, який використовується для зберігання значень true або false. тобто він може зберігати значення true або false.
//long - це цілочисельний тип даних, який займає 8 байт пам'яті. тобто він може зберігати значення від -9,223,372,036,854,775,808 до 9,223,372,036,854,775,807.
//short - це цілочисельний тип даних, який займає 2 байти пам'яті. тобто він може зберігати значення від -32,768 до 32,767.
//byte - це цілочисельний тип даних, який займає 1 байт пам'яті. тобто він може зберігати значення від 0 до 255.
//decimal - це тип даних, який займає 16 байт пам'яті. тобто він може зберігати значення від ±1.0 x 10^-28 до ±7.9 x 10^28.
//uint - це цілочисельний тип даних, який займає 4 байти пам'яті. тобто він може зберігати значення від 0 до 4,294,967,295.
//ulong - це цілочисельний тип даних, який займає 8 байт пам'яті. тобто він може зберігати значення від 0 до 18,446,744,073,709,551,615.
//ushort - це цілочисельний тип даних, який займає 2 байти пам'яті. тобто він може зберігати значення від 0 до 65,535.
//sbyte - це цілочисельний тип даних, який займає 1 байт пам'яті. тобто він може зберігати значення від -128 до 127.