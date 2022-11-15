// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] aray = {3, 7, 22, 2, 78};

int maxNum = 0;
int minNum = 22;

for(int i = 0; i<aray.Length; i++)
{
    if(aray[i]>maxNum)
    {
        maxNum = aray[i];
    }
    if(aray[i]<minNum){
        minNum = aray[i];
    }
}
Console.WriteLine($"Максимальное число = {maxNum}");
Console.WriteLine($"Минимальное число = {minNum}");
Console.WriteLine($"Разница = {maxNum-minNum}");
