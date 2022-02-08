// See https://aka.ms/new-console-template for more information
float i = 1;
float j = 1;

for (i = 1; i < 101; i++)
{
    j = i % 3 + i % 5;
    if (j == 0) { Console.WriteLine($"FizzBizz"); continue; }
    j = i % 3;
    if (j == 0) { Console.WriteLine($"Fizz"); continue; }
    j = i % 5;
    if (j == 0) { Console.WriteLine($"Bizz"); }
    else if (j > 0) Console.WriteLine($"{i}");




}
Console.ReadLine();   //пауза при закрытии