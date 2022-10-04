Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
CreateArray(numbers);
PrintArray(numbers);
int count = 0;
for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] % 2 == 0)
        count++;
}
Console.WriteLine($"количество четных - {count}");
void CreateArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
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
