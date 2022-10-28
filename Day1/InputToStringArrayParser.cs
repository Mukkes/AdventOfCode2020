namespace AdventOfCode2020.Day1
{
    public class InputToStringArrayParser : IInputParser<string[]>
    {
        public string[] Parse(string inputFileName)
        {
            return File.ReadAllLines(inputFileName);
        }
    }
}
