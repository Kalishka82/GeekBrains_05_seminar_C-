// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

Console.Write("Input number N: ");
int N = int.Parse(Console.ReadLine()!);

int[] numbers = CreateArray(10);
PrintArray(numbers);

bool isNumberInArray = NumberInArray(numbers);
string txt = isNumberInArray == true? $"{N} IS in numbers" : $"{N} IS NOT in numbers";
Console.WriteLine(txt);

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

bool NumberInArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] != N)
                return false;
        }
    return true;
}