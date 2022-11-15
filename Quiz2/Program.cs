// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] aray = new int[4];

for(int i = 0; i<aray.Length; i++)
{
aray[i]= new Random().Next(1000);

Console.Write(aray[i]+", ");
}

int sum = 0;

for(int i=1; i<aray.Length; i+=2)
{
    sum += aray[i];

}
Console.WriteLine();
Console.WriteLine($"Количество четных эл массива: {sum}");
