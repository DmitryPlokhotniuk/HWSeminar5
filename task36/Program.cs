/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] array = new int[10];

void FillArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 30);
    }
    Console.WriteLine(String.Join(", ", array));
}

int SumElements (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

FillArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SumElements(array)}");