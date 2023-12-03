using AdventOfCode2023.Interfaces;
using AdventOfCode2023.SharedServices;

namespace AdventOfCode.Day1;

public class Puzzle1 : IPuzzle
{
    public void Solve()
    {
        Console.WriteLine("Solving Day 1, Puzzle 1");
        /*
            1abc2
            pqr3stu8vwx
            a1b2c3d4e5f
            treb7uchet

            In this example, the calibration values of these four lines are 12, 38, 15, and 77. Adding these together produces 142. 
        */
        var filePath = "";
        var inputLines = FileService.GetFileLines(filePath);
        int problemSum = 0;
        try
        {
            foreach (var input in inputLines)
            {
                //Console.WriteLine("Input:" + input);
                //Console.WriteLine("Problem sum so far: " + problemSum);
                var digits = input.Where(char.IsDigit).ToArray();
                //Console.WriteLine(digits);
                if (digits.Length > 0)
                {
                    if (digits.Length > 1) 
                    {
                        var firstLastCombination = int.Parse(string.Concat(digits[0], digits[^1]));
                        problemSum += firstLastCombination;
                        //Console.WriteLine("Added: " + firstLastCombination);
                    }
                    else
                    {
                        problemSum += digits[0] - '0';
                        //Console.WriteLine("Added: " + digits[0]);
                    }
                } else
                {
                    problemSum += 0;
                    //Console.WriteLine("Added: 0");
                }
            }
        } catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}