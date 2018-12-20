﻿using System.Collections.Generic;

using Xunit;

namespace AdventOfCode2018.Tests.Day3
{
    public class NoMatterHowYouSliceItTests
    {
        private readonly NoMatterHowYouSliceIt _noMatterHowYouSliceIt;

        public NoMatterHowYouSliceItTests()
        {
            _noMatterHowYouSliceIt = new NoMatterHowYouSliceIt();
        }

        [Theory]
        [JsonFileData("Day3/testData.json", "Part1", typeof(string), typeof(int))]
        public void GetTotalOverlappingCoordinatesCountReturnsCorrectCount(List<string> claims, int expectedResult)
        {
            var result = _noMatterHowYouSliceIt.GetTotalOverlappingCoordinatesCount(claims);
            Assert.Equal(expectedResult, result);
        }
    }
}