
for (int i = 0; i < 37; i++)
{
    if (Peek())
    {
        Move();
    }
} //14

Turn();
Move();
Move();
Turn(); //12

void TurnLeft()
{

    for (int turns = 0; turns < 3; turns++)
    {
        Turn();
    }
}

for (int k = 0; k < 36; k++)
{
    if (Peek())
    {
        Move();
    }
    //Turn(); 
}

TurnLeft();

for (int m = 0; m < 2; m++)
{
    if (Peek())
    {
        Move();
    }
}
TurnLeft(); //10

for (int k = 0; k < 36; k++)
{
    if (Peek())
    {
        Move();
    }
    Turn();
}
for (int m = 0; m < 2; m++)
{
    if (Peek())
    {
        Move();
    }
}

Turn(); //8

for (int k = 0; k < 36; k++)
{
    if (Peek())
    {
        Move();
    }
    //Turn(); 
}






for (int l = 0; l < 38; l++)
{
    if (Peek())
    {
        Move();
    }
    else if
    {
        AtGoal()
    }
}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
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