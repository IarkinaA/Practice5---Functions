// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] aray = new int[4];

for(int i = 0; i<aray.Length; i++)
{
aray[i]= new Random().Next(100, 1000);

Console.Write(aray[i]+", ");
}

int count = 0;

for(int i=0; i<aray.Length; i++)
{
if(aray[i]%2==0)
{
    count++;
}
}
Console.WriteLine();
Console.WriteLine($"Количество четных эл массива: {count}");
