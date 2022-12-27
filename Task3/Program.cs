//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


Console.WriteLine("Enter number1: ");
int N1 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number1: ");
int N2 = int.Parse(Console.ReadLine());

int [] array = new int[8];

for (int i = 0; i < 8; i++)
{
    var rnd = new Random();
    array[i] = rnd.Next(N1, N2+1);

    System.Console.Write(array[i]+" ");
}
