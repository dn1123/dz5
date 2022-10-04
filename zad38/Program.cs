Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
CreateArray(numbers);
PrintArray(numbers);
double min = numbers[0];
double max = numbers[0];

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > max)
        {
            max = numbers[j];
        }
    if (numbers[j] < min)
        {
            min = numbers[j];
        }
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {(max - min):F2}");



void CreateArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    foreach (double number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine("]");
}
