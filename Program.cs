// Simple Dice Game
/*Create a console application for a simple dice game. The game should follow these rules:
Display a welcome message: Simple Dice Game

Prompt the user to input 'Roll' or 'R'.

If the user input is 'Roll' or 'R':
Roll three dice (each with sides numbered from 1 to 6).
Calculate the total score based on the sum of the three dice rolls.
Determine if the user rolled a triple (all three dice have the same number) or a double (at least two dice have the same number). Assign appropriate points: triple (6 points), double (2 points), or no points.
Display the dice rolls and the total score

Determine the user's prize based on the total points:
If the total points are between 22 and 24, congratulate the user and mention a grand prize.
If the total points are exactly 21, congratulate the user and mention a specific prize.
If the total points are between 18 and 20, congratulate the user and mention a general prize.
If the total points are 17, mention a specific prize.
If the total points are between 14 and 16, mention a prize.
If the total points are between 10 and 13, mention a prize.
If the total points are less than 10, suggest rolling again.
Implement the game logic and prize determination following the rules mentioned above.*/

    Console.WriteLine("*****Simple Dice Game*****\nType 'Roll' or 'R' to roll the die");

    string? startGame = Console.ReadLine();

    while  (!(startGame.Equals("Roll", StringComparison.OrdinalIgnoreCase) || startGame.Equals("R", StringComparison.OrdinalIgnoreCase)))
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Enter correct key to continue play th game");
        Console.ResetColor();
        Console.Write("Type 'Roll' or 'R' to roll the die: ");
        startGame = Console.ReadLine()!;
        return;
    }    
       
    Random random = new Random();
    int diceOne = random.Next(1,7);
    int diceTwo = random.Next(1,7);
    int diceThree = random.Next(1,7);
    int originalScore = diceOne + diceTwo + diceThree;
    const int DOUBLE_POINT = 2;
    const int TRIPLE_POINT = 6;
    int totalPoint = originalScore;

    if (diceOne == diceTwo && diceTwo == diceThree)
    {
        totalPoint += TRIPLE_POINT;
        Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled a triple! You have a total of {totalPoint} points");
    }

    else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
    {
        totalPoint += DOUBLE_POINT;
        Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled a Double! You have a total of {totalPoint} points");
    }
    else
        Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou have a total of {totalPoint} points");

{
    if (totalPoint >= 22 && totalPoint <= 24)
        Console.WriteLine("Congratulation, you won all gifts. Awesome!");
    else if (totalPoint == 21)
        Console.WriteLine("Congratulation, you won a Samsung A20. Bravo!");
    else if (totalPoint >= 18 && totalPoint <= 20)
        Console.WriteLine("Congratulation, you won all gifts. Awesome!");
    else if (totalPoint == 17)
        Console.WriteLine("Congratulation, you won a 5000mAhPowerbank. Awesome!");
    else if (totalPoint >= 14 && totalPoint <= 16)
        Console.WriteLine("Congratulation, you won a book.");
    else if (totalPoint >= 10 && totalPoint <= 13)
        Console.WriteLine("Congratulation, you won a balloon.");
    else
        Console.WriteLine("Sorry! Roll again.");
}