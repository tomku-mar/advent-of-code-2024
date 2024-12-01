namespace AdventOfCode2024.Tests.Day1;

using AdventOfCode2024.Day1;

public class LocationsTests
{
    [Theory]
    [MemberData(nameof(LocationsData))]
    public void Should_ReturnsCorrectDistance(Locations locations, int expectedTotalDistance)
    {
        Assert.True(expectedTotalDistance == locations.GetTotalDistance());
    }

    public static IEnumerable<object[]> LocationsData(){
        yield return [new Locations([3, 4, 2, 1, 3, 3], [4, 3, 5, 3, 9, 3]), 11];
        yield return [new Locations([1, 2, 1, 3, 3, 5], [6, 11, 77, 3, 2, 4]), 88];
        yield return [new Locations([4, 14, 14, 13, 16, 3], [50, 12, 1, 1, 2, 7]), 59];
    }
}