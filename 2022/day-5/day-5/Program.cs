foreach (var top in Solution.PuzzleTwo(Solution.GetCrateLists(Solution.GetInput()),
             Solution.GetMoves(Solution.GetInput())))
{
    Console.WriteLine(top.UnsortedContent.TakeLast(1).LastOrDefault());
}
static class Solution
{
    public static IEnumerable<ContainerStack> PuzzleOne(IEnumerable<ContainerStack> stacks, IEnumerable<Move> moves)
    {
        foreach (var move in moves)
        {
            for (int i = 0; i < move.Amount; i++)
            {
                stacks.First(s => s.Name == move.To).Content.Push(stacks.First(s => s.Name == move.From).Content.Peek());
                stacks.First(s => s.Name == move.From).Content.Pop();
            }
        }
        return stacks;
    }

    public static IEnumerable<ContainerStack> PuzzleTwo(IEnumerable<ContainerStack> stacks, IEnumerable<Move> moves)
    {
        foreach (var move in moves)
        {
            stacks.First(s => s.Name == move.To).UnsortedContent
                .AddRange(
                    stacks.First(s=>s.Name == move.From).UnsortedContent
                    .Skip(
                            stacks.First(s=>s.Name == move.From).UnsortedContent.Count - move.Amount));
            stacks.First(s => s.Name == move.From).UnsortedContent
                .RemoveRange(
                    stacks.First(s => s.Name == move.From).UnsortedContent.Count - move.Amount , 
                    move.Amount);
            
        }
        return stacks;
    }

    public static IEnumerable<ContainerStack> GetCrateLists(IEnumerable<string> input)
    {
        List<string[]> contents = new List<string[]>();
        foreach (var line in input.Take(8))
        {
            var lineArray = line.Split(" ");
            contents.Add(lineArray);
        }
        
        //Make arrays vertical
        var verticalContent  =
            Enumerable.Range(0, 9)
                .Select(i => contents.Select(x => x[i])
                    .ToArray()
                ).ToArray();

        List<ContainerStack> stacks = new List<ContainerStack>();
        foreach (var stack in input.Skip(8).Take(8).First().Split(" "))
        {
            if (!string.IsNullOrEmpty(stack))
            {
                var stackInt = int.Parse(stack);
                stacks.Add(new ContainerStack()
                {
                    Name = stackInt,
                    Content = new Stack<string>(verticalContent[stackInt - 1].Where(c => c != "[0]").Reverse().ToList()),
                    UnsortedContent = verticalContent[stackInt - 1].Where(c => c != "[0]").Reverse().ToList(),
                });
            }
            
        }

        return stacks;
    }

    public static List<Move> GetMoves(IEnumerable<string> input)
    {
        List<Move> movesList = new List<Move>();
        foreach (var line in input.Skip(10))
        {
            var lineArray = line.Split(" ");
            movesList.Add(new Move()
            {
                Amount = int.Parse(lineArray[1]),
                To = int.Parse(lineArray[5]),
                From = int.Parse(lineArray[3])
            });
        }

        return movesList;
    }
    
    public static IEnumerable<string> GetInput()
    {
        return File.ReadLines("../../../input.txt");
    }
}

class ContainerStack 
{
    public int Name { get; set; }
    public Stack<string> Content { get; set; }
    public List<string> UnsortedContent { get; set; }
}
class Move
{
    public int From { get; set; }
    public int To { get; set; }
    public int Amount { get; set; }
}