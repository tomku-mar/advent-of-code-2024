// <copyright file="Locations.cs" company="Equiniti">
// Copyright (c) Equiniti 2022. All Rights Reserved
// </copyright>

namespace AdventOfCode2024.Day1
{
    public class Locations
    {
        public List<int> LeftLocations { get; }
        public List<int> RightLocations { get; }

        public Locations(List<int> leftLocations, List<int> rightLocations)
        {
            LeftLocations = leftLocations;
            RightLocations = rightLocations;
        }

        public int GetTotalDistance()
        {
            var orderedLeftLocations = LeftLocations.OrderBy(x => x).ToList();
            var orderedRightLocations = RightLocations.OrderBy(x => x).ToList();

            var totalDistance = 0;
            for (var i = 0; i < orderedLeftLocations.Count; i++)
            {
                var leftDistance = orderedLeftLocations[i];
                var rightDistance = orderedRightLocations[i];

                totalDistance += Math.Abs(leftDistance - rightDistance);
            }

            return totalDistance;
        }
    }
}