// Домашнее задание задача №1
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.Write("Введите число A-> ");
int NumberA = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число В-> ");
int NumberB = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число C-> ");
int NumberC = Convert.ToInt32(Console.ReadLine());

if (NumberA > NumberB) {
    if (NumberA > NumberC) {
        System.Console.WriteLine($"Большее число = {NumberA}");
    } else {
        System.Console.WriteLine($"Большее число = {NumberC}");
    }
} else {
    if (NumberB > NumberC) {
        System.Console.WriteLine($"Большее число = {NumberB}");
    } else {
        System.Console.WriteLine($"Большее число = {NumberC}");
    }
}
