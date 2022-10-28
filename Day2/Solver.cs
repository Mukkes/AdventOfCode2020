namespace AdventOfCode2020.Day2
{
    internal class Solver : StringArraySolver
    {
        protected override object SolvePartOne()
        {
            var count = 0;
            foreach (var row in Input)
            {
                var passwordPolicy = ExtractPasswordPolicy(row);
                if (passwordPolicy.IsValidPassword(ExtractPassword(row)))
                {
                    count++;
                }
            }
            return count;
        }

        protected override object SolvePartTwo()
        {
            var count = 0;
            foreach (var row in Input)
            {
                var passwordPolicy = ExtractPasswordPolicy(row);
                if (passwordPolicy.IsValidPasswordPartTwo(ExtractPassword(row)))
                {
                    count++;
                }
            }
            return count;
        }

        private PasswordPolicy ExtractPasswordPolicy(string row)
        {
            var arr = row.Split(' ');
            var numbers = arr[0].Split('-');
            return new PasswordPolicy(int.Parse(numbers[0]), int.Parse(numbers[1]), arr[1].First());
        }

        private string ExtractPassword(string row)
        {
            var arr = row.Split(' ');
            return arr[2];
        }
    }
}
