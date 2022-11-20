using System.Linq;
using BenchmarkDotNet.Attributes;

namespace Benchmarking;

public class StringComparison
{
    private string ttsf; // text to search for
    private string[] tc; // text collection

    [GlobalSetup]
    public void Setup()
    {
        ttsf = "i want this";
        tc = new string[]
        {
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "i want this"
        };
    }

    [Benchmark]
    public string LinqFirstOrDefault()
    {
        return tc.FirstOrDefault(x => x == ttsf);
    }

    [Benchmark]
    public string LinqFirstOrDefault_StringLength()
    {
        int textToSearchForLength = ttsf.Length;
        return tc.First(x => x.Length == textToSearchForLength && x == ttsf);
    }

    [Benchmark]
    public string LinqFirst()
    {
        return tc.First(x => x == ttsf);
    }

    [Benchmark]
    public string LinqFirst_StringLength()
    {
        int textToSearchForLength = ttsf.Length;
        return tc.First(x => x.Length == textToSearchForLength && x == ttsf);
    }

    [Benchmark]
    public string ForeachLoop()
    {
        foreach (string str in tc)
            if (str == ttsf)
                return str;
        return null;
    }

    [Benchmark]
    public string ForeachLoop_StringLength()
    {
        int textToSearchForLength = ttsf.Length;
        foreach (string str in tc)
            if (str.Length == textToSearchForLength && str == ttsf)
                return str;
        return null;
    }

    [Benchmark]
    public string ForLoop()
    {
        for (int i = 0; i < tc.Length; i++)
            if (tc[i] == ttsf)
                return tc[i];
        return null;
    }

    [Benchmark(Baseline = true)]
    public string ForLoop_StringLength()
    {
        int textToSearchForLength = ttsf.Length;
        for (int i = 0; i < tc.Length; i++)
            if (tc[i].Length == textToSearchForLength && tc[i] == ttsf)
                return tc[i];
        return null;
    }
}
