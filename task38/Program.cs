/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] array = new double[10];

void FillArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = Convert.ToDouble(new Random().Next(1,10000)) / 100;
    }
    Console.WriteLine(string.Join(", ", array));
}

double MaxElement(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > max) max = array [i];
    }
    return max;
}
double MinElement(double[] array, double max)
{
    double min = max;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] < min) min = array [i];
    }
    return min;
}
FillArray (array);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {MaxElement(array) - MinElement(array, MaxElement(array))}");