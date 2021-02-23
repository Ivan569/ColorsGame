using System;
using System.Drawing;
using System.Windows.Forms;

class ColorButton : Button
{
    public Color Color { get; }

    public ColorButton(string text, Color color)
    {
        Text = text;
        Color = color;
        BackColor = Color.White;
    }  
}

class MainForm : Form
{
    public MainForm(string name)
    {
        Text = name;
        Size = new Size(195, 155);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        ColorButton red = new ColorButton("красный", Color.Red);
        red.SetBounds(40, 20, 100, 20);
        red.Click += (x, y) => BackColor = red.Color;
        ColorButton green = new ColorButton("зеленый", Color.Green);
        green.SetBounds(40, 40, 100, 20);
        green.Click += (x, y) => BackColor = green.Color;
        ColorButton blue = new ColorButton("синий", Color.DarkBlue);
        blue.SetBounds(40, 60, 100, 20);
        blue.Click += (x, y) => BackColor = blue.Color;
        ColorButton yellow = new ColorButton("желтый", Color.Yellow);
        yellow.SetBounds(40, 80, 100, 20);
        yellow.Click += (x, y) => BackColor = yellow.Color;
        Controls.Add(red);
        Controls.Add(green);
        Controls.Add(blue);
        Controls.Add(yellow);
    }
}

class ColorGame
{
    [STAThread]
    static void Main()
    {
        Application.Run(new MainForm("Colors"));
    }
}