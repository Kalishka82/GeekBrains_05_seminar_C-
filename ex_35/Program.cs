// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите
//  количество элементов массива, значения которых лежат в отрезке 
// [10,99]. 

int[] numbers = CreateArray(123);
// PrintArray(numbers);
Console.WriteLine(CountElementsInRange(numbers));

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

int CountElementsInRange(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] <= 99 && numbers[i] >= 10)
        {
            count ++;
        }

    }
    return count;
}
