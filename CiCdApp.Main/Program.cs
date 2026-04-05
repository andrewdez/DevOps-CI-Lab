using System;

namespace CiCdApp.Main;

// Класична точка входу
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, DevOps CI/CD!");
    }
}

// Наш клас для тестування
public class Calculator
{
    public int Add(int a, int b) => a + b;
}