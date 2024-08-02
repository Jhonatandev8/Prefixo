namespace Prefixo;

class Program
{
    static void Main(string[] args)
    {
        Solution solution= new Solution();
        string[] strs = { "flower", "flow", "flight" };
        string result = solution.LongestCommonPrefix(strs);
        Console.WriteLine(result);
    }
}
