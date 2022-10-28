using AdventOfCode2020.Day1;

namespace AdventOfCode2020.Day2
{
    public abstract class StringArraySolver : BaseSolver<string[]>
    {
        public StringArraySolver() : base(new InputToStringArrayParser()) { }
    }
}
