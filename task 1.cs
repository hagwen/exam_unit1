int onemove = 0;




//Console.WriteLine(onemove);

for (int i = 0; i < 37; i++)
{

    if (Peek())
    {
        Move();

    }

} //14
Console.WriteLine(onemove);

Turn();
Console.WriteLine("turnright.");
Move();
Move();
Console.WriteLine(onemove);
Turn(); //12
Console.WriteLine("turnright.");



for (int k = 0; k < 36; k++)
{
    if (Peek())
    {
        Move();
    }
    //Turn(); 
}
Console.WriteLine(onemove);

TurnLeft();

for (int m = 0; m < 2; m++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
TurnLeft(); //10

for (int k = 0; k < 36; k++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

for (int m = 0; m < 2; m++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);

Turn(); //8
Console.WriteLine("turnright.");

for (int k = 0; k < 36; k++)
{
    if (Peek())
    {
        Move();
    }
    //Turn(); 
}
Console.WriteLine(onemove);
TurnLeft();

for (int q = 0; q < 2; q++)
{
    if (Peek())
    {
        Move();
    }
} //6
Console.WriteLine(onemove);

TurnLeft();

for (int k = 0; k < 36; k++)
{
    if (Peek())
    {
        Move();
    }
}
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");


for (int u = 0; u < 2; u++)
{
    if (Peek())
    {
        Move();
    }
} //4
Console.WriteLine(onemove);

for (int k = 0; k < 36; k++)
{
    if (Peek())
    {
        Move();
    }
    //Turn();
}
Console.WriteLine(onemove);

TurnLeft();

for (int u = 0; u < 2; u++)
{
    if (Peek())
    {
        Move();
    }
} //2
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");


for (int l = 0; l < 38; l++)
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
//Console.WriteLine(onemove);

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