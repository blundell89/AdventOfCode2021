using System;
using System.Linq;
using System.Threading.Tasks;
using AoC.App;
using FluentAssertions;
using Xunit;

namespace AoC.Test
{
    public class Day1
    {
        [Fact]
        public async Task Test1_Increments()
        {
            using var reader = ResourceReaderFactory.Create("1-1.txt");
            var data = (await reader.ReadToEndAsync())
                .Split(Environment.NewLine)
                .Select(int.Parse)
                .ToArray();

            Day1_SonarSweep.CalculateIncrements(data).Should().Be(1477);
        }

        [Fact]
        public async Task Test2_SlidingWindow()
        {
            using var reader = ResourceReaderFactory.Create("1-2.txt");
            var data = (await reader.ReadToEndAsync())
                .Split(Environment.NewLine)
                .Select(int.Parse)
                .ToArray();

            Day1_SonarSweep.CalculateIncrements(data, 3).Should().Be(1523);
        }
    }
}