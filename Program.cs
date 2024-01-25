int onemove = 0;

// Define the maze (you'll need to implement logic to check the maze structure)
bool[,] maze = new bool[,]
{
    { true, false, true, true, true },
    { true, true, true, false, true },
    { true, false, false, true, true },
    { true, true, true, true, true },
    { true, true, false, false, true }
};

int currentRow = 0;    // Initial position
int currentCol = 0;

while (!AtGoal())
{
    // Check if the cell in the direction the car is facing is open
    if (Peek(currentRow, currentCol))
    {
        Move();
        onemove++;

        // Update the car's position based on the direction it's facing
        // (Assuming initially facing to the right)
        if (currentCol < maze.GetLength(1) - 1 && maze[currentRow, currentCol + 1])
        {
            currentCol++;
        }
    }
    else
    {
        // If the way forward is blocked, turn left
        TurnLeft();
        onemove++;

        // Update the car's direction accordingly
        // (Assuming initially facing to the right)
        // (Adjust the logic based on the car's initial direction)
        if (currentRow > 0 && maze[currentRow - 1, currentCol])
        {
            currentRow--;
        }
    }
}

Console.WriteLine("Maze successfully navigated!");

void TurnLeft()
{
    Console.WriteLine("Turned left");
    for (int turns = 0; turns < 3; turns++)
    {
        Turn();
    }
}

bool Peek(int row, int col)
{
    // Returns true if the next cell is open, otherwise false.
    if (col < maze.GetLength(1) - 1 && maze[row, col + 1])
    {
        return false;
    }
    return false;
}

void Move()
{
    // Moves the car 1 cell in the direction it is heading.
    Console.WriteLine($"Moved to ({currentRow}, {currentCol + 1})");
}

void Turn()
{
    // Turns the car 90 deg clockwise.
    Console.WriteLine("Turned right");
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return (currentRow == maze.GetLength(0) - 1 && currentCol == maze.GetLength(1) - 1);
}
