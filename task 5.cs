int onemove = 0;

for (int i = 0; i < 3; i++)
{

    if (Peek())
    {
        Move();

    }

}
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

for (int y = 0; y < 7; y++)
{

    if (Peek())
    {
        Move();

    }

}
Console.WriteLine(onemove);
TurnLeft();

Move();
Move();
Console.WriteLine(onemove);
TurnLeft();

for (int r = 0; r < 3; r++)
{

    if (Peek())
    {
        Move();

    }

}
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

for (int w = 0; w < 4; w++)
{

    if (Peek())
    {
        Move();

    }

}
Console.WriteLine(onemove);
TurnLeft();
Move();
Move();
Console.WriteLine(onemove);
TurnLeft();

for (int q = 0; q < 4; q++)
{

    if (Peek())
    {
        Move();

    }

}
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

for (int c = 0; c < 7; c++)
{

    if (Peek())
    {
        Move();

    }

}
Console.WriteLine(onemove);
TurnLeft();

for (int l = 0; l < 1; l++)
{
    if (Peek())
    {
        Move();

    }
}

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