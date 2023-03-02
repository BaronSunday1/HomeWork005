//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 99) + rand.NextDouble();
}

void PrintArray(double[] array)
{
    System.Console.WriteLine($"[" + string.Join(", ", array) + "]");
}

double max = array[0];
double min = array[0];
for (int i = 1; i < 5; i++)
{
    if (array[i] < min)
        min = array[i];
    if (array[i] > max)
        max = array[i];
}

PrintArray(array);

System.Console.WriteLine($"Summ even numbers = {max - min}");
