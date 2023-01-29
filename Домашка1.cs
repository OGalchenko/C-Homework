// Домашнее задание задача №1
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


   Console.Write("Введите число A>");
   
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите число В");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            System.Console.WriteLine($"Большее число = {firstNumber}, Меньшее число = {secondNumber}");
        }
        else
        {
            System.Console.WriteLine($"Большее число = {secondNumber}, Меньшее число = {firstNumber}");
        }


