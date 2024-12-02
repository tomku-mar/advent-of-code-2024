namespace AdventOfCode2024.Day2
{
    public class Report
    {
        public List<int> Levels { get; }

        public Report(List<int> levels)
        {
            Levels = levels;
        }

        public bool IsSafe()
        {
            return !AreContainEquals() && !AreDifferencesBiggerThanThree() && (AreAllDecreasing() || AreAllIncreasing());
        }

        private bool AreAllDecreasing()
        {
            for (int i = 1; i < Levels.Count; i++)
            {
                if (Levels[i] >= Levels[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        private bool AreAllIncreasing()
        {
            for (int i = 1; i < Levels.Count; i++)
            {
                if (Levels[i] <= Levels[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        private bool AreContainEquals()
        {
            for (int i = 1; i < Levels.Count; i++)
            {
                if (Levels[i] == Levels[i - 1])
                {
                    return true;
                }
            }

            return false;
        }

        private bool AreDifferencesBiggerThanThree()
        {
            for (int i = 1; i < Levels.Count; i++)
            {
                if (Math.Abs(Levels[i] - Levels[i - 1]) > 3)
                {
                    return true;
                }
            }

            return false;
        }
    }
}