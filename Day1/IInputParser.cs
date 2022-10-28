namespace AdventOfCode2020.Day1
{
    public interface IInputParser<TResult>
    {
        TResult Parse(string inputFileName);
    }
}
