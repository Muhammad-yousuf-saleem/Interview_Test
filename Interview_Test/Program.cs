public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 2, 3, 3, 3 };
        var numberCounts = Program.GetNumberCounts(numbers);
        var formattedResult = string.Join(", ", numberCounts.Select(count => $"{count.Key}: {count.Value}"));
        Console.WriteLine(formattedResult);
    }


    public static Dictionary<int, int> GetNumberCounts(List<int> numbers)
    {
        var numberCountDictionary = numbers
            .GroupBy(number => number)
            .ToDictionary(group => group.Key, group => group.Count());
        return numberCountDictionary;
    }
}