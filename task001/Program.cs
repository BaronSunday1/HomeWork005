// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] GenArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine($"[" + string.Join(", ", array) + "]");
}
void EvNumber(int[] array, out int evenNumber)
{
    evenNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNumber++;
        }
    }
}
var secArray = GenArray(4);

PrintArray(secArray);
EvNumber(secArray, out int evenN);

System.Console.WriteLine($"Summ even numbers = {evenN}");
