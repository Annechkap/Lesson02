// 3. Напишите программу, которая выводит третью цифру заданного числа  или сообщает, что третьей цифры нет

int Prompt(string message)
{
    Console.WriteLine(message);
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}

int number=Prompt("Введите число:   ");
if (number < 100)
{
    Console.WriteLine($"Ой, в этом числе нет третьей цифры");
}
else 
{
    while (number>=1000)
    {
        number=number/10;
    }
    number=number%10;
    Console.WriteLine($"Третья цифра {number}");
}

