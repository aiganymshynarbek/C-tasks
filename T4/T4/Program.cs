Random random = new Random();
int [] numbers = new int [10];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(1, 101);
    Console.Write(numbers[i] + " ");
}

Console.WriteLine();

int max = numbers[0];
int min = max;
double sum = 0;

for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
        if (numbers[i] > max)
        {
            max = numbers[i];
        }

        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }

double avg = sum / numbers.Length;
Console.WriteLine($"Max is: {max}");
Console.WriteLine($"Min is: {min}");
Console.WriteLine($"Avg is: {avg}");






