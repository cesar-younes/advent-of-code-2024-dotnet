namespace AdventOfCode2024.Days;

public static class Day2
{
    public static void Part1()
    {
        Console.WriteLine("Day 2, Part 1");
        List<List<int>> Reports = Inputs.GetDay2Reports();
        int SafeReportCount = 0;

        foreach (var report in Reports)
        {
            if (IsSafe(report))
            {
                SafeReportCount++;
            }
        }
        Console.WriteLine("Safe Reports: " + SafeReportCount);
    }

    public static void Part2()
    {
        Console.WriteLine("Day 2, Part 2");
        List<List<int>> Reports = Inputs.GetDay2Reports();
        int SafeReportCount = 0;
        string SafeReports = "";

        foreach (var report in Reports)
        {
            for (int i = 0; i < report.Count; i++)
            {
                List<int> newReport = new(report);
                newReport.RemoveAt(i);
                if (IsSafe(newReport))
                {
                    SafeReportCount++;
                    SafeReports += string.Join(" ", newReport) + "\n";
                    break;
                }
            }
        }
        Console.WriteLine("Safe Reports: " + SafeReportCount);
    }

    public static bool IsSafe(List<int> report)
    {
        if (IsConsistentlyIncreasing(report.ToArray()) || IsConsistentlyDecreasing(report.ToArray()))
        {
            for (int i = 0; i < report.Count; i++)
            {
                if (i < report.Count - 1)
                {
                    int difference = Math.Abs(report[i] - report[i + 1]);
                    if (difference > 0 && difference < 4)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (i == report.Count - 1)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static bool IsConsistentlyIncreasing(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsConsistentlyDecreasing(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}
