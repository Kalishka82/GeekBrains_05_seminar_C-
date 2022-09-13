// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
//  из промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
// элементов массива.

int[] numbers = CreateRandomArray(12);
PrintArray(numbers);
int positiveSum = CalcPositiveSum(numbers);
int negativeSum = CalcNegativeSum(numbers);
Console.WriteLine($"Сумма положительных = {positiveSum}");
Console.WriteLine($"Сумма отрицательных = {negativeSum}");

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        System.Console.Write($"{number} ");
    }
    Console.WriteLine();
}

int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];
 
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-9, 10);
    }
    return numbers;
}

int CalcPositiveSum(int[] numbers)
{
    int positiveSum = 0;
    foreach (int number in numbers) // для каждого числа из массива чисел
    {
        if (number > 0)
            positiveSum += number;
    }
    return positiveSum;
}

int CalcNegativeSum(int[] numbers)
{
    int negativeSum = 0;
    foreach (int number in numbers) // для каждого числа из массива чисел
    {
        if (number < 0)
            negativeSum += number;
    }
    return negativeSum;
}