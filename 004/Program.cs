// 4. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, являеться ли этоот день выходным

int Prompt(string message)
{
    Console.WriteLine(message);
    int number=Convert.ToInt32(Console.ReadLine());
    return number;
}

int number=Prompt("Введите цифру, обозначающую день недели:   ");
if (number ==6 || number ==7)
{
    Console.WriteLine($"{number} день - выходной");
}
else 
{
Console.WriteLine($"{number} день - не выходной");
}
