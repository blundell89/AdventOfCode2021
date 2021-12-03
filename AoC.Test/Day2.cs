using System;
using System.Threading.Tasks;
using AoC.App;
using FluentAssertions;
using Xunit;

namespace AoC.Test;

public class Day2
{
    [Fact]
    public void Test1_Dive_Example()
    {
        var commands = new[]
        {
            "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2"
        };

        var result = Day2_Dive.CalculatePositionDepth(commands);
        (result.Horizontal * result.Depth).Should().Be(150);
    }

    [Fact]
    public async Task Test1_Dive()
    {
        using var reader = ResourceReaderFactory.Create("2-1.txt");
        var commands = (await reader.ReadToEndAsync()).Split(Environment.NewLine);

        var result = Day2_Dive.CalculatePositionDepth(commands);
        (result.Horizontal * result.Depth).Should().Be(1840243);
    }

    [Fact]
    public void Test2_Dive_Example()
    {
        var commands = new[]
        {
            "forward 5",
            "down 5",
            "forward 8",
            "up 3",
            "down 8",
            "forward 2"
        };

        var result = Day2_Dive.CalculatePositionDepthRevisited(commands);
        (result.Horizontal * result.Depth).Should().Be(900);
    }

    [Fact]
    public async Task Test2_Dive()
    {
        using var reader = ResourceReaderFactory.Create("2-1.txt");
        var commands = (await reader.ReadToEndAsync()).Split(Environment.NewLine);

        var result = Day2_Dive.CalculatePositionDepthRevisited(commands);
        (result.Horizontal * result.Depth).Should().Be(1727785422);
    }
}