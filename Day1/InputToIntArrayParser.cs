namespace AdventOfCode2020.Day1
{
    public class InputToIntArrayParser : IInputParser<int[]>
    {
        public int[] Parse(string inputFileName)
        {
            var input = File.ReadAllLines(inputFileName);
            return Array.ConvertAll(input, int.Parse);
        }
    }
}
