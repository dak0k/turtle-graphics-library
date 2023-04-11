# C# Turtle Graphics Library

This is a simple turtle graphics library implemented in C# that provides basic functionality for drawing on a canvas using turtle-like commands.

## Usage

To use this turtle graphics library in your C# project, you can follow these steps:

1. Clone or download this repository to your local machine.

2. Add the `Turtle.cs` file to your C# project. You can do this by right-clicking on your project in the Visual Studio Solution Explorer, selecting "Add" > "Existing Item", and then selecting the `Turtle.cs` file from the cloned/downloaded repository.

3. In your C# code, you can import the `TurtleGraphics` namespace to use the `Turtle` class. Here's an example:

```csharp
using System;
using System.Drawing;
using System.Windows.Forms;
using TurtleGraphics;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new turtle
            PictureBox canvas = new PictureBox();
            Turtle turtle = new Turtle(canvas);

            // Draw a square
            turtle.PenDown();
            for (int i = 0; i < 4; i++)
            {
                turtle.Forward(100);
                turtle.TurnRight(90);
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
You can customize the turtle graphics operations by calling the methods of the Turtle class, such as Forward, TurnLeft, TurnRight, PenUp, PenDown, and Clear, to create your own graphics designs.

If you find any issues or have suggestions for improvement, feel free to open an issue or submit a pull request. Contributions are welcome!
