int onemove = 0;
Turn();
Console.WriteLine("turnright.");

for (int i = 0; i < 4; i++)
{
    if (Peek())
    {
        Move();

    }
}
Console.WriteLine(onemove);

TurnLeft();

for (int i = 0; i < 4; i++)
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
Console.WriteLine(onemove);
TurnLeft();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

for (int k = 0; k < 3; k++)
{
    if (Peek())
    {
        Move();

    }
}
Console.WriteLine(onemove);
TurnLeft();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
for (int t = 0; t < 5; t++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
TurnLeft();
for (int a = 0; a < 3; a++)
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
Console.WriteLine(onemove);
TurnLeft();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Console.WriteLine(onemove);
TurnLeft();
Move();
Move();
Console.WriteLine(onemove);

for (int f = 0; f < 5; f++)
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
Console.WriteLine(onemove);
TurnLeft();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Move();
Console.WriteLine(onemove);
TurnLeft();

for (int s = 0; s < 3; s++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

for (int e = 0; e < 3; e++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);

TurnLeft();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Move();
Console.WriteLine(onemove);
TurnLeft();


for (int e = 0; e < 3; e++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
TurnLeft();

for (int e = 0; e < 3; e++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

for (int e = 0; e < 5; e++)
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
Console.WriteLine(onemove);
TurnLeft();

for (int e = 0; e < 4; e++)
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
TurnLeft();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Console.WriteLine(onemove);
TurnLeft();
Move();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Console.WriteLine(onemove);

for (int e = 0; e < 4; e++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

for (int l = 0; l < 2; l++)
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