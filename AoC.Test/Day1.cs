using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace AoC.Test
{
    public class Day1
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public Day1(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public async Task Test1()
        {
            int increases = 0;
            int? previousMeasurement = null;

            using var reader = ResourceReaderFactory.Create("1-1.txt");
            while (!reader.EndOfStream)
            {
                var current = await reader.ReadLineAsync();
                if (current is null)
                    break;


                var currentTemp = int.Parse(current);
                if (currentTemp > previousMeasurement)
                    increases++;

                previousMeasurement = currentTemp;
            }

            _testOutputHelper.WriteLine(increases.ToString());
        }

        [Fact]
        public async Task Test2()
        {
            int increases = 0;

            using var reader = ResourceReaderFactory.Create("1-2.txt");
            var arr = (await reader.ReadToEndAsync())
                .Split(Environment.NewLine)
                .Select(int.Parse)
                .ToArray();

            foreach (var (x, y) in arr.Zip(arr[3..]))
            {
                if (x < y)
                    increases++;
            }
            _testOutputHelper.WriteLine(increases.ToString());
        }
    }
}