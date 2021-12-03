namespace AoC.App
{
    public class Day1_SonarSweep
    {
        public static int CalculateIncrements(int[] data, int? slidingWindow = null)
        {
            int increases = 0;

            foreach (var (x, y) in data.Zip(data[(slidingWindow ?? 1)..]))
            {
                if (x < y)
                    increases++;
            }

            return increases;
        }
    }
}