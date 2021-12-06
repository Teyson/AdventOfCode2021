// See https://aka.ms/new-console-template for more information

using System;

Task1();
Task2();

void Task2()
{
    string[] lines =
        System.IO.File.ReadAllLines(
            "C:\\Users\\teis\\OneDrive\\Dokumenter\\Programmering\\Advent of Code 2021\\AoC1\\AoC1\\input.txt");

    var sumOfIncreases = -1;
    int prev = 0;
    int current = 0;

    for (int i = 2; i < lines.Length; i++)
    {
        current += int.Parse(lines[i - 2]);
        current += int.Parse(lines[i - 1]);
        current += int.Parse(lines[i]);

        if (current > prev)
        {
            sumOfIncreases++;
        }

        prev = current;
        current = 0;
    }

    Console.WriteLine(sumOfIncreases);
}

void Task1()
{
    string[] lines =
        System.IO.File.ReadAllLines(
            "C:\\Users\\teis\\OneDrive\\Dokumenter\\Programmering\\Advent of Code 2021\\AoC1\\AoC1\\input.txt");

    var sum = 0;
    int prev = 156;

    foreach (string line in lines)
    {
        int numOnLine = int.Parse(line);

        if (numOnLine > prev)
        {
            sum++;
        }

        prev = numOnLine;
    }

    Console.WriteLine(sum);
}