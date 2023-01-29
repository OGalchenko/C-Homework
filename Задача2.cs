// Домашнее задание задача №2
// Задача 2: Напишите программу, которая на вход принимает три числа и выдаёт максимальное из этих чисел.


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
