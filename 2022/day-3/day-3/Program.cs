
Console.WriteLine("Solution one: " + Solutions.PuzzleOne(Solutions.GetInput()));
Console.WriteLine("Solution two: " + Solutions.PuzzleTwo(Solutions.GetInput()));
static class Solutions
{
    public static IEnumerable<string> GetInput()
    {
        return File.ReadLines("../../../input.txt");
    }
    
    public static int PuzzleOne(IEnumerable<string> input)
    {
        int total = 0;
        foreach (string line in input)
        {
            var firstHalf = line.Substring(0, line.Length / 2).Distinct();
            var secondHalf = line.Substring(line.Length / 2);
            
            foreach (char c in firstHalf.Where(f=>secondHalf.Contains(f)))
            {
                var charValue = (int) c;
                if (charValue > 90)
                    total += charValue - 96;
                else
                    total += charValue - 38;
            }
        }
        return total;
    }
    
    public static int PuzzleTwo(IEnumerable<string> input)
    {
        int total = 0;
        List<char> badgeList = new List<char>();

        foreach (var group in input.Chunk(3))
            badgeList.AddRange(group[0].Distinct().Where(zero => group[1].Contains(zero) && group[2].Contains(zero))); 
        
        foreach (char c in badgeList)
        {
            var charValue = (int) c;
            if (charValue > 90)
                total += charValue - 96;
            else
                total += charValue - 38;
        }
        return total;
    }
}

