int onemove = 0;
const int loopLimmit = 5;
const int mediumLimmit = 4;
const int shorterLimmit = 3;
const int MoveTwoFOrward = 2;


Turn();
Console.WriteLine("turnright.");
mediumrange();
Console.WriteLine(onemove);
TurnLeft();
mediumrange();
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
shortvol1();
Console.WriteLine(onemove);
TurnLeft();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
longestLimmit();
Console.WriteLine(onemove);
TurnLeft();
shortvol1();
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
move2forward();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Console.WriteLine(onemove);
TurnLeft();
move2forward();
Console.WriteLine(onemove);
TurnLeft();
longestLimmit();
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
move2forward();
Console.WriteLine(onemove);
TurnLeft();
shortvol1();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
shortvol1();
Console.WriteLine(onemove);
TurnLeft();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
move2forward();
Console.WriteLine(onemove);
TurnLeft();
shortvol1();
Console.WriteLine(onemove);
TurnLeft();
shortvol1();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
longestLimmit();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Console.WriteLine(onemove);
TurnLeft();
mediumrange();
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
Console.WriteLine(onemove);
TurnLeft();
move2forward();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Console.WriteLine(onemove);
TurnLeft();
mediumrange();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

move2forward();
Console.WriteLine(onemove);
if (AtGoal())
{
    Console.WriteLine("yeeeey, winner winner chicken dinner.");
    return;
}





void TurnLeft()
{
    Console.WriteLine("Turned left");
    for (int turns = 0; turns < 3; turns++)
    {
        Turn();
    }
}

void mediumrange()
{
    for (int i = 0; i < mediumLimmit; i++)
    {
        if (Peek())
        {
            Move();

        }
    }
}

void longestLimmit()
{
    for (int e = 0; e < loopLimmit; e++)
    {
        if (Peek())
        {
            Move();
        }
    }
}

void shortvol1()
{
    for (int k = 0; k < shorterLimmit; k++)
    {
        if (Peek())
        {
            Move();

        }
    }
}

void move2forward()
{
    for (int l = 0; l < MoveTwoFOrward; l++)
    {
        if (Peek())
        {
            Move();

        }
    }
}

#region Basic functions


void Move()
{


    onemove++;

}

void Turn()
{


}

bool Peek()
{

    return true;
}

bool AtGoal()
{

    return true;
}

#endregion