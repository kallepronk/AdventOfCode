// See https://aka.ms/new-console-template for more information

Console.WriteLine(Solution.PuzzleTwo(Solution.GetInput()));

static class Solution
{
    public static int PuzzleOne(IEnumerable<string> pairs)
    {
        int total = 0;
        foreach (var pair in pairs)
        {
            //splitting on hyphens and commas means that the first two items in this list are from elf 1 and the second two items are elf 2.
            var pairArray = pair.Split(new char[] {'-', ','}).Select(int.Parse).ToArray();
            if (pairArray[0] >= pairArray[2] && pairArray[0] <= pairArray[3] &&
                pairArray[1] >= pairArray[2] && pairArray[1] <= pairArray[3]) 
                total++;
            else if (pairArray[2] >= pairArray[0] && pairArray[2] <= pairArray[1] &&
                     pairArray[3] >= pairArray[0] && pairArray[3] <= pairArray[1]) 
                total++;
        }
        return total;
    }
    
    public static int PuzzleTwo(IEnumerable<string> pairs)
    {
        int total = 0;
        foreach (var pair in pairs)
        {
            //splitting on hyphens and commas means that the first two items in this list are from elf 1 and the second two items are elf 2.
            var pairArray = pair.Split(new char[] {'-', ','}).Select(int.Parse).ToArray();
            if (pairArray[0] >= pairArray[2] && pairArray[0] <= pairArray[3] ||
                pairArray[1] >= pairArray[2] && pairArray[1] <= pairArray[3]) 
                total++;
            else if (pairArray[2] >= pairArray[0] && pairArray[2] <= pairArray[1] ||
                     pairArray[3] >= pairArray[0] && pairArray[3] <= pairArray[1])
                total++;
        }
        return total;
    }
    
    public static IEnumerable<string> GetInput()
    {
        return File.ReadLines("../../../input.txt");
    }
}