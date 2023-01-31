Console.WriteLine("Введите размер массива : ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandomArray(numbers);
GetArray(numbers);
int count = 0;

for (int evennumber = 0; evennumber < numbers.Length; evennumber++)
if (numbers[evennumber] % 2 == 0)
count++;

Console.WriteLine($"Чётных" + " " + count);

void RandomArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void GetArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}