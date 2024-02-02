int onemove = 0;
const int loopLimmit = 15;
const int MoveElevenForward = 11;
const int MoveThreeForward = 3;
const int MoveFiveForward = 5;
const int MoveFourForward = 4;
const int MoveSevenForward = 7;
const int MoveForward = 13;
const int MoveSixsForward = 6;
const int MoveNineForward = 9;
const int MoveEightForward = 8;
const int MoveTenForward = 10;
const int MoveTwelveForward = 12;


MovingForward(MoveThreeForward);
Console.WriteLine(onemove);
Turn();
Move();
Move();
Console.WriteLine(onemove);
Turn();

MovingForward(MoveFiveForward);
Console.WriteLine(onemove);

Turn();

MovingForward(MoveFourForward);
Console.WriteLine(onemove);
Turn();

MovingForward(MoveSevenForward);
Console.WriteLine(onemove);
Turn();

MovingForward(MoveSixsForward);
Console.WriteLine(onemove);
Turn();

MovingForward(MoveNineForward);
Console.WriteLine(onemove);
Turn();

MovingForward(MoveEightForward);
Console.WriteLine(onemove);
Turn();

MovingForward(MoveElevenForward);
Console.WriteLine(onemove);
Turn();

MovingForward(MoveTenForward);
Console.WriteLine(onemove);
Turn();

MovingForward(MoveForward);
Console.WriteLine(onemove);
Turn();

MovingForward(MoveTwelveForward);
Console.WriteLine(onemove);
Turn();

MovingForward(loopLimmit);
Console.WriteLine(onemove);
Turn();


MovingForward(MoveForward);
Console.WriteLine(onemove);
if (AtGoal())
{
    Console.WriteLine("yeeeey, winner winner chicken dinner.");
    return;
}





void MovingForward(int number)
{
    for (int u = 0; u < number; u++)
    {
        if (Peek())
        {
            Move();
        }
    }
}
#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
    onemove++;
}

void Turn()
{
    // Turns the car 90 deg clockwise.
    Console.WriteLine("turnright.");
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion