using AdventOfCode2023.Interfaces;

namespace AdventOfCode2023;

public static class PuzzleRunner
{
    public static void RunPuzzle(string day, string puzzle)
    {
        string typeName = $"AdventOfCode.{day}.Puzzle{puzzle}";
        var puzzleType = Type.GetType(typeName);
        try { 
            var puzzleInstance = (IPuzzle)Activator.CreateInstance(puzzleType);
            puzzleInstance.Solve();
        } catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    static void Main()
    {
        PuzzleRunner.RunPuzzle("Day1", "1");
    }
}
