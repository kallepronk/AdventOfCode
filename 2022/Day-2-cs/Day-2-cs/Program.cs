// See https://aka.ms/new-console-template for more information

int totalScore = 0;

foreach (string line in File.ReadLines("../../../input.txt"))
{
    int score = 0;
    var match = line.Split(" ");
    switch (match[1])
    {
        case "X":
        {
            if (match[0] == "A")
            {
                score = 3;
            }
            else if (match[0] == "B")
            {
                score = 1;
            }
            else if (match[0] == "C")
            {
                score = 2;
            }
            break;
        }
        case "Y":
        {
            if (match[0] == "A")
            {
                score = 4;
            }
            else if (match[0] == "B")
            {
                score = 5;
            }
            else if (match[0] == "C")
            {
                score = 6;
            }
            break;
        }
        case "Z":
        {
            if (match[0] == "A")
            {
                score = 8;
            }
            else if (match[0] == "B")
            {
                score = 9;
            }
            else if (match[0] == "C")
            {
                score = 7;
            }
            break;
        }
    }
    Console.WriteLine(score);
    totalScore += score;
}  

Console.WriteLine("Total: " + totalScore );