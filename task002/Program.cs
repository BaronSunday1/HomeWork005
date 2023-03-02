// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] GenArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(-99, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.WriteLine($"[" + string.Join(", ", array) + "]");
}
void NegativePosition(int[] array, out int sum)
{
    sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
        sum += array[i];
        
    }
}
var secArray = GenArray(4);
PrintArray(secArray);
NegativePosition(secArray, out int sum);
System.Console.WriteLine($"Sum of odd elements = {sum}");

