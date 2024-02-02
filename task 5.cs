int onemove = 0;
const int MoveThreeForward = 3;
const int MoveFourForward = 4;
const int MoveSevenForward = 7;
const int OneForward = 1;
const int TwoForward = 2;

MovingForward(MoveThreeForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

MovingForward(MoveSevenForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(TwoForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(MoveThreeForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

MovingForward(MoveFourForward);
Console.WriteLine(onemove);
TurnLeft();
MovingForward(TwoForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(MoveFourForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
MovingForward(TwoForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

MovingForward(MoveSevenForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(OneForward);

Console.WriteLine(onemove);

if (AtGoal())
{
    Console.WriteLine("yeeeey, winner winner chicken dinner.");
    return;
}




//my functions
void TurnLeft()
{
    Console.WriteLine("Turned left");
    for (int turns = 0; turns < 3; turns++)
    {
        Turn();
    }
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