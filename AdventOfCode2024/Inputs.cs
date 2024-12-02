namespace AdventOfCode2024;

public static class Inputs
{
    public static List<int> GetDay1List1()
    {
        return GetIntListFromFile("InputFiles/day1list1.txt");
    }

    public static List<int> GetDay1List2()
    {
        return GetIntListFromFile("InputFiles/day1list2.txt");
    }

    public static List<List<int>> GetDay2Reports()
    {
        return GetDoubleIntListFromFile("InputFiles/day2reports.txt");
    }

    private static List<int> GetIntListFromFile(string path)
    {
        List<int> list1 = [];
        try
        {
            using (StreamReader sr = new(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    list1.Add(int.Parse(line));
                }
            }

            return list1;
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
            throw;
        }
    }

    private static List<List<int>> GetDoubleIntListFromFile(string path)
    {
        List<List<int>> list1 = [];
        try
        {
            using (StreamReader sr = new(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] array = line.Split(' ');
                    List<int> innerList = [];
                    foreach (var item in array)
                    {
                        innerList.Add(int.Parse(item));
                    }
                    list1.Add(innerList);
                }
            }

            return list1;
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
            throw;
        }
    }
}
