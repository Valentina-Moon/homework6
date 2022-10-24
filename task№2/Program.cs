//Показать числа Фибоначчи//

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
    Console.WriteLine("Значение элемента Фибоначчи: ");
    int n = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine();

for (int i = 1; i < n; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}

// есть второе решение task5