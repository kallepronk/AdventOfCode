Console.WriteLine(Solution.PuzzleOneANDTwoOrSoItSeems(Solution.GetInput(), 14));

static class Solution
{
    public static int PuzzleOneANDTwoOrSoItSeems(string input, int markerLength)
    {
        for (int i = 0; i < input.Length - markerLength; i++)
        {
            if (input.Substring(i, markerLength).ToHashSet().Count == markerLength)
            {
                Console.WriteLine(input.Substring(i, markerLength));
                return i + markerLength;
            }
        }
        throw new Exception("No markers found");
    }
    
    public static string GetInput()
    {
        return File.ReadAllText("../../../input.txt");
    }
}