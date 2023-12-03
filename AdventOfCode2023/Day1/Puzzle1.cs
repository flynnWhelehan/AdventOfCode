using AdventOfCode2023.Interfaces;
using AdventOfCode2023.SharedServices;

namespace AdventOfCode.Day1;

public class Puzzle1 : IPuzzle
{
    public void Solve()
    {
        Console.WriteLine("Solving Day 1, Puzzle 1");

        var filePath = "";
        var inputLines = FileService.GetFileLines(filePath);
        int problemSum = 0;
        try
        {
            foreach (var input in inputLines)
            {
                var digits = input.Where(char.IsDigit).ToArray();
                if (digits.Length > 0)
                {
                    if (digits.Length > 1)
                    {
                        var firstLastCombination = int.Parse(string.Concat(digits[0], digits[^1]));
                        problemSum += firstLastCombination;
                    }
                    else
                    {
                        var singleDigitValue = digits[0] - '0';
                        problemSum += singleDigitValue * 10 + singleDigitValue;
                    }
                }
                else
                {
                    problemSum += 0;
                }
            }
            Console.WriteLine("Final value: " + problemSum);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}