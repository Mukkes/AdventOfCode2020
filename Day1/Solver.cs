namespace AdventOfCode2020.Day1
{
    internal class Solver : IntArraySolver
    {
        protected override object SolvePartOne()
        {
            for (int i = 0; i < Input.Length; i++)
            {
                for (int j = i + 1; j < Input.Length; j++)
                {
                    if (Input[i] + Input[j] == 2020)
                    {
                        return Input[i] * Input[j];
                    }
                }
            }
            throw new Exception();
        }

        protected override object SolvePartTwo()
        {
            for (int i = 0; i < Input.Length; i++)
            {
                for (int j = i + 1; j < Input.Length; j++)
                {
                    for (int k = j + 1; k < Input.Length; k++)
                    {
                        if (Input[i] + Input[j] + Input[k] == 2020)
                        {
                            return Input[i] * Input[j] * Input[k];
                        }
                    }
                }
            }
            throw new Exception();
        }
    }
}
