namespace AdventOfCode2020.Day1
{
    public abstract class IntArraySolver : BaseSolver<int[]>
    {
        public IntArraySolver() : base(new InputToIntArrayParser()) { }
    }
}
