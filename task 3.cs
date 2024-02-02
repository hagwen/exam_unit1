int onemove = 0;
const int MoveElevenForward = 11;
const int MoveThreeForward = 3;
const int MoveFiveForward = 5;
const int MoveSevenForward = 7;
const int MoveTenForward = 10;
const int TwoForward = 2;


MovingForward(MoveElevenForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
Move();
Move();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

MovingForward(MoveTenForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(TwoForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(MoveTenForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
MovingForward(TwoForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

MovingForward(MoveTenForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(MoveSevenForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(TwoForward);
Console.WriteLine(onemove);

TurnLeft();

MovingForward(MoveFiveForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
MovingForward(TwoForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

MovingForward(MoveFiveForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(TwoForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(MoveFiveForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
MovingForward(TwoForward);
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

MovingForward(MoveFiveForward);
Console.WriteLine(onemove);
TurnLeft();

MovingForward(MoveThreeForward);
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