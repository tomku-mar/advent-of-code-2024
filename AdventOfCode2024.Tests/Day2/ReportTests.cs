namespace AdventOfCode2024.Tests.Day2
{
    using AdventOfCode2024.Day2;

    public class ReportTests
    {
        [Theory]
        [InlineData(7, 6, 4, 2, 1)]
        [InlineData(7, 6, 4, 2, 1, 0)]
        [InlineData(7, 4, 3, 2, -1)]
        public void Should_BeSafe_When_AllDecreasing(params int[] levels)
        {
            var report = new Report(levels.ToList());

            Assert.True(report.IsSafe());
        }

        [Theory]
        [InlineData(1, 3, 6, 7, 9)]
        [InlineData(0, 1, 3, 6, 7, 9)]
        [InlineData(-3, -1, 1, 4, 7)]
        public void Should_BeSafe_When_AllIncreasing(params int[] levels)
        {
            var report = new Report(levels.ToList());

            Assert.True(report.IsSafe());
        }

        [Theory]
        [InlineData(1, 2, 7, 8, 9)]
        [InlineData(-1, 5, 7, 8, 9)]
        public void Should_BeUnsafe_When_ContainIncreasingBiggerThanThree(params int[] levels)
        {
            var report = new Report(levels.ToList());

            Assert.False(report.IsSafe());
        }

        [Theory]
        [InlineData(9, 7, 6, 2, 1)]
        [InlineData(9, 7, 6, 5, -1)]
        public void Should_BeUnsafe_When_ContainDecreasingBiggerThanThree(params int[] levels)
        {
            var report = new Report(levels.ToList());

            Assert.False(report.IsSafe());
        }

        [Theory]
        [InlineData(1, 3, 2, 4, 5)]
        [InlineData(-1, 1, 2, 1, 0)]
        public void Should_BeUnsafe_When_ContainDecreasing_And_Increasing(params int[] levels)
        {
            var report = new Report(levels.ToList());

            Assert.False(report.IsSafe());
        }

        [Theory]
        [InlineData(8, 6, 4, 4, 1)]
        [InlineData(6, 4, 2, -1, -1)]
        public void Should_BeUnsafe_When_ContainEquality(params int[] levels)
        {
            var report = new Report(levels.ToList());

            Assert.False(report.IsSafe());
        }

        [Theory]
        [InlineData(3, 1, 4, 2, 5)]
        [InlineData(1, -1, 2, 3, 5)]
        public void Should_BeUnsafe_When_Contain_Increasing_And_Decreasing(params int[] levels)
        {
            var report = new Report(levels.ToList());

            Assert.False(report.IsSafe());
        }

        [Theory]
        [InlineData(7, 6, 4, 2, 1)]
        [InlineData(1, 3, 2, 4, 5)]
        [InlineData(8, 6, 4, 4, 1)]
        [InlineData(1, 3, 6, 7, 9)]
        public void Should_BeSafeWithoutOneLevel(params int[] levels)
        {
            var report = new Report(levels.ToList());

            Assert.True(report.IsSafeWithoutOneLevel());
        }

        [Theory]
        [InlineData(1, 2, 7, 8, 9)]
        [InlineData(9, 7, 6, 2, 1)]
        public void Should_BeUnsafeWithoutOneLevel(params int[] levels)
        {
            var report = new Report(levels.ToList());

            Assert.False(report.IsSafeWithoutOneLevel());
        }
    }
}