int onemove = 0;
const int loopLimmit = 37;
const int shorterLimmit = 36;
const int TwoForward = 2;
const int gettingToGoal = 38;






GoingMedium();
Console.WriteLine(onemove);

Turn();
Console.WriteLine("turnright.");
MovingTwoForward();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");



GoingSmal();

Console.WriteLine(onemove);

TurnLeft();

MovingTwoForward();
Console.WriteLine(onemove);
TurnLeft();

GoingSmal();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");

MovingTwoForward();
Console.WriteLine(onemove);

Turn();
Console.WriteLine("turnright.");

GoingSmal();
Console.WriteLine(onemove);
TurnLeft();

MovingTwoForward();
Console.WriteLine(onemove);

TurnLeft();

GoingSmal();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");


MovingTwoForward();
Console.WriteLine(onemove);
Turn();
Console.WriteLine("turnright.");
GoingSmal();
Console.WriteLine(onemove);

TurnLeft();

MovingTwoForward();
Console.WriteLine(onemove);
TurnLeft();


GoingTOGoal();
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

void GoingMedium()
{
    for (int i = 0; i < loopLimmit; i++)
    {

        if (Peek())
        {
            Move();

        }

    }
}

void GoingSmal()
{
    for (int k = 0; k < shorterLimmit; k++)
    {
        if (Peek())
        {
            Move();
        }

    }
}

void GoingTOGoal()
{
    for (int l = 0; l < gettingToGoal; l++)
    {
        if (Peek())
        {
            Move();

        }
    }
}

void MovingTwoForward()
{
    for (int u = 0; u < TwoForward; u++)
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