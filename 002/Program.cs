// 2. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

int number=new Random().Next(100,1000);
Console.WriteLine($"Случайное число {number}");
int newnumber = (number/100) *10 + number%10;
Console.WriteLine($"Число без второй цифры: {newnumber}");

