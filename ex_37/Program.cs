// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и 
// т.д. Результат запишите в новом массиве.

int[] numbers = CreateArray(9);
PrintArray(numbers);
int[] multipliedVector = NumbersProduceFromPair(numbers);
PrintArray(multipliedVector);

int[] CreateArray(int size)
{
    int[] numbers = new int[size];

    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-100, 101);
    }    
    return numbers;
}


void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}


int[] NumbersProduceFromPair(int[] numbers)

{
    int[] multipliedVector = new int[(numbers.Length) / 2];
    for (int i = 0; i < numbers.Length/2; i++)
        multipliedVector[i] = numbers[i] * numbers[numbers.Length - 1 - i];
    return multipliedVector;
}