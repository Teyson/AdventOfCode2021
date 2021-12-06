// See https://aka.ms/new-console-template for more information

using System;

UBoat uBoat = new UBoat(0, 0, 0);

string[] lines =
    System.IO.File.ReadAllLines(
        "C:\\Users\\teis\\OneDrive\\Dokumenter\\Programmering\\AdventOfCode2021\\AoC2\\input.txt");

foreach (string line in lines)
{
    string[] split = line.Split(" ");
    uBoat.Steer(split[0], int.Parse(split[1]));
}

Console.WriteLine(uBoat.Depth * uBoat.HorizontalPos);

class UBoat
{
    public int HorizontalPos { get; set; }
    public int Depth { get; set; }
    public int Aim { get; set; }

    public UBoat(int horizontalPos, int depth, int aim)
    {
        this.HorizontalPos = horizontalPos;
        this.Depth = depth;
        Aim = aim;
    }

    public void Steer(string direction, int amount)
    {
        switch (direction)
        {
            case "forward":
                Forward(amount);
                break;
            case "down":
                Down(amount);
                break;
            case "up":
                Up(amount);
                break;
        }
    }

    public void Forward(int amount)
    {
        HorizontalPos += amount;
        Depth += amount * Aim;
    }

    public void Down(int amount)
    {
        Aim += amount;
    }

    public void Up(int amount)
    {
        Aim -= amount;
    }
}