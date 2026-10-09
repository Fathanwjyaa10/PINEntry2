int pin;

do
{
    Console.Write("Enter your PIN (must be between 1000 and 9999): ");
    pin = int.Parse(Console.ReadLine());

    if (pin < 1000 || pin > 9999)
    {
        Console.WriteLine("PIN must be between 1000-9999! Try Again...");
    }

} while (pin < 1000 || pin > 9999);