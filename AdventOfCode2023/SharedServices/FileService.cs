namespace AdventOfCode2023.SharedServices;
public class FileService
{
    public static string[]? GetFileLines(string filePath)
    {
        try
        {
            return File.ReadAllLines(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
            return null;
        }
    }
}

