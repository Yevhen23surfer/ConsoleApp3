int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false; // Initialize found outside the loop

int total = 0; 
foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        found = true;
        break; // No need to continue looping once 42 is found
    }
}

if (found)
{
    Console.WriteLine("Set contains 42");
}

Console.WriteLine($"Total: {total}"); // This total will only reflect the last iteration's value
