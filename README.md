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
```
##Example

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

            // Set up the canvas
            canvas.Width = 800;
            canvas.Height = 600;
            canvas.BackColor = Color.White;

            // Add the canvas to a form
            Form form = new Form();
            form.Controls.Add(canvas);

            // Draw a square
            turtle.PenDown();
            for (int i = 0; i < 4; i++)
            {
                turtle.Forward(100);
                turtle.TurnRight(90);
            }

            // Wait for form to close
            form.ShowDialog();

            // Dispose of the turtle and canvas
            turtle.Dispose();
            canvas.Dispose();
        }
    }
}

```

### Contributing
If you would like to contribute to the Turtle Graphics Library, you can fork the GitHub repository and submit pull requests with your changes. Please follow the contributing guidelines for more information on how to contribute to the project.
</br>

<p></p>
In this example, we create a Turtle object and a PictureBox object to serve as the canvas for drawing. We then set up the canvas by specifying its size and background color, and add it to a Form object. We use the PenDown() method to lower the turtle's pen to the canvas, and then use the Forward() and TurnRight() methods to draw a square. Finally, we use form.ShowDialog() to display the form with the canvas, and wait for the form to close before disposing of the turtle and canvas objects.
<p></p>
You can customize the turtle's movements and drawing commands, as well as the canvas size, background color, and other settings, to create your own graphical designs using the C# Turtle Graphics Library.

<hr>
You can customize the turtle graphics operations by calling the methods of the Turtle class, such as Forward, TurnLeft, TurnRight, PenUp, PenDown, and Clear, to create your own graphics designs.

If you find any issues or have suggestions for improvement, feel free to open an issue or submit a pull request. Contributions are welcome!
