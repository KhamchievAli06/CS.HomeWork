using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int reversedNumber = ReverseNumber(number);

        Console.WriteLine($"Перевёрнутое число: {reversedNumber}");
    }

    static int ReverseNumber(int number)
    {
        int reversedNumber = 0;
        while (number > 0)
        {
            int lastDigit = number % 10; 
            reversedNumber = reversedNumber * 10 + lastDigit; 
            number /= 10; 
        }
        return reversedNumber; 
    }
}
