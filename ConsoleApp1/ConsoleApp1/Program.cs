// Окремий статичний клас FibonacciHelper
public static class FibonacciHelper
{
    // Рекурсивний метод для обчислення числа Фібоначчі
    public static int GetFibonacciNumber(int n)
    {
        if (n == 0)
            return 0; // Перше число в послідовності
        if (n == 1)
            return 1; // Друге число в послідовності

        // Рекурсивне обчислення
        return GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
    }
}

// Головний клас програми
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть номер числа Фібоначчі:");
        int inputNumber = int.Parse(Console.ReadLine());

        // Виклик методу для обчислення числа Фібоначчі
        int fibonacciNumber = FibonacciHelper.GetFibonacciNumber(inputNumber);

        Console.WriteLine($"Число Фібоначчі порядку {inputNumber}: {fibonacciNumber}");
    }
}
