int[] numbers = new int[4];
numbers[0] = 2;
PrintEvenNumbers(numbers);

void PrintEvenNumbers(int[] numbers)
{
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine(number);
        }
    }
}
