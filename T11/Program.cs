﻿// Напишите программу, которая будет выдавать название дня недели по заданному номеру.;
// 3 -> среда;
// 5 -> пятница;

Console.WriteLine("Введите день недели числом: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 == 1)
    Console.WriteLine("Понедельник");
if (number1 == 2)
    Console.WriteLine("Вторник");
if (number1 == 3)
    Console.WriteLine("Среда");
if (number1 == 4)
    Console.WriteLine("Четверг");
if (number1 == 5)
    Console.WriteLine("Пятница");
if (number1 == 6)
    Console.WriteLine("Суббота");
if (number1 == 7)
    Console.WriteLine("Воскресенье");
if (number1 > 7)
    Console.WriteLine("Не правильное значение");
if (number1 < 1)
   Console.WriteLine("Не правильное значение");
