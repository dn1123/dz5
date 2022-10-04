Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
CreateArray(numbers);
PrintArray(numbers);
int sum = 0;
for (int j = 1; j < numbers.Length; j += 2)
{
    sum = sum + numbers[j];
}
Console.WriteLine($"сумма элементов на нечётных позициях - {sum}");
void CreateArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    foreach (int number in numbers)
    {
        Console.Write($"{number}, ");
        Console.Write($"{number} ");
    }
    Console.WriteLine("]");
}
