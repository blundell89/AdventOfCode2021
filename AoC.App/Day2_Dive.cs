namespace AoC.App
{
    public class Day2_Dive
    {
        public static (int Horizontal, int Depth) CalculatePositionDepth(string[] commands)
        {
            var splitCommands = commands.Select(x =>
            {
                var split = x.Split(' ');

                return (Command: split[0], Num: int.Parse(split[1]));
            }).ToArray();

            int x = 0, y = 0;

            foreach (var (command, num) in splitCommands)
            {
                switch (command)
                {
                    case "forward":
                        x += num;
                        break;
                    case "down":
                        y += num;
                        break;
                    case "up":
                        y -= num;
                        break;
                }
            }

            return (x, y);
        }

        public static (int Horizontal, int Depth) CalculatePositionDepthRevisited(string[] commands)
        {
            var splitCommands = commands.Select(x =>
            {
                var split = x.Split(' ');

                return (Command: split[0], Num: int.Parse(split[1]));
            }).ToArray();

            int x = 0, y = 0, aim = 0;

            foreach (var (command, num) in splitCommands)
            {
                switch (command)
                {
                    case "forward":
                        x += num;
                        y += (aim * num);
                        break;
                    case "down":
                        aim += num;
                        break;
                    case "up":
                        aim -= num;
                        break;
                }
            }

            return (x, y);
        }
    }
}
