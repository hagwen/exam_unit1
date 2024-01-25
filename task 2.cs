int onemove = 0;



Move();
Move();
Move();
Console.WriteLine(onemove);
Turn();
Move();
Move();
Console.WriteLine(onemove);
Turn();

for (int i = 0; i < 5; i++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);

Turn();

for (int j = 0; j < 4; j++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();

for (int k = 0; k < 7; k++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();

for (int y = 0; y < 6; y++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();

for (int p = 0; p < 9; p++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();

for (int q = 0; q < 8; q++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();

for (int t = 0; t < 11; t++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();

for (int h = 0; h < 10; h++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();

for (int d = 0; d < 13; d++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();

for (int l = 0; l < 12; l++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();

for (int m = 0; m < 15; m++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();


for (int å = 0; å < 13; å++)
{
    if (Peek())
    {
        Move();
        Console.WriteLine(onemove);

    }
}

if (AtGoal())
{
    Console.WriteLine("yeeeey, winner winner chicken dinner.");
    return;
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