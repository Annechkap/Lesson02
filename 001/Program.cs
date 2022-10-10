// 1.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int Prompt(string message)
{
    Console.WriteLine(message);
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}
int number=Prompt("Введите число:   ");
if (number > 99 & number < 1000)
{
    int number2=0;
    number2=(number/10)%10;
    Console.WriteLine($"Вторая цифра трехзначного числа {number2}");
}
else
{
    Console.WriteLine($"Это не трехзначное число");
}

