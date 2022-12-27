// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter num: ");
int N = int.Parse(Console.ReadLine());

int i = 0;
int temp = 0;

for(;N>0;N/=10)
{
    temp = temp + N%10;
    i++;
}

Console.WriteLine($"{temp} ");