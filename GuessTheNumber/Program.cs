namespace GuessTheNumber;

class Program
{
    static void Main(string[] args)
    {
        Random roll = new Random();
        int rollValue = roll.Next(1, 10);
        int guess = 0;

        do
        {
            Console.WriteLine("Guess the number rolled! Pick a number between 1 and 10.");
            guess = int.Parse(Console.ReadLine());

            if (guess < rollValue)
            {
                Console.WriteLine("Too low...guess again!");
            }
            else if (guess > rollValue)
            {
                Console.WriteLine("Too high...guess again.");
            }
        } while (guess != rollValue);

        if (guess == rollValue)
        {
            Console.WriteLine("You guessed it! Congratulations!");
        }
    }
}