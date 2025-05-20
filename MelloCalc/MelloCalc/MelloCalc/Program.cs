using System;

class MelloCalc
{
    static void Main()
    {
        Console.WriteLine("MelloCalc kalkulyatoruna xoş gəlmisiniz!");

        Console.Write("Birinci ədədi daxil edin: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Əməliyyatı daxil edin (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        Console.Write("İkinci ədədi daxil edin: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        bool valid = true;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine("0-a bölmək olmaz!");
                    valid = false;
                }
                else
                {
                    result = num1 / num2;
                }
                break;

            default:
                Console.WriteLine("Yanlış əməliyyat daxil etdiniz!");
                valid = false;
                break;
        }

        if (valid)
        {
            Console.WriteLine($"Nəticə: {result}");
        }
    }
}
