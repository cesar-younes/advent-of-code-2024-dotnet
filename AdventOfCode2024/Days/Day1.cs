namespace AdventOfCode2024.Days;

public static class Day1
{
    public static void Part1()
    {
        Console.WriteLine("Day 1, Part 1");
        List<int> List1 = Inputs.GetDay1List1();
        List<int> List2 = Inputs.GetDay1List2();
        Console.WriteLine("List1 "+List1.Count);
        Console.WriteLine("List2 " + List2.Count);
        
        List1.Sort();
        List2.Sort();
        
        int Total = 0;

        for (int index = 0; index < List1.Count; index++)
        {
            Total += Math.Abs(List1[index] - List2[index]);
        }

        Console.WriteLine("Total: " + Total);
    }
    public static void Part2()
    {
        Console.WriteLine("Day 1, Part 2");
        List<int> List1 = Inputs.GetDay1List1();
        List<int> List2 = Inputs.GetDay1List2();
        Console.WriteLine("List1 " + List1.Count);
        Console.WriteLine("List2 " + List2.Count);

        int SimilarityScore = 0;

        for (int index = 0; index < List1.Count; index++)
        {
            SimilarityScore += (List1[index] * List2.Count(c => c == List1[index]));
        }

        Console.WriteLine("Total: " + SimilarityScore);
    }
}
