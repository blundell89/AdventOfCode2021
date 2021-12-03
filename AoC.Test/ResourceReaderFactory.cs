using System.IO;

namespace AoC.Test;

public class ResourceReaderFactory
{
    public static StreamReader Create(string filename)
    {
        var x = typeof(Day1).Assembly.GetManifestResourceStream($"AoC.Test.{filename}");
        return new StreamReader(x!);
    }
}