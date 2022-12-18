/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
}
int[] array = GetArray(10, -10, 10);
PrintArray(array);

int SumUneven(int [] array)
{
    int sum = 0;
    int i = 1;
    while (i <= array.Length)
    {
        sum = sum + array[i];
        i = i +2;
    }
    return sum;
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {SumUneven(array)}");