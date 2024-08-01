using System.Linq;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using Modding;

namespace Benchmarking;

public class ReflectionComparison
{
    private static int testToGet;

    [Benchmark]
    public int ReflectionTest()
    {
        FieldInfo testFI = typeof(ReflectionComparison).GetField(nameof(testToGet), BindingFlags.Static | BindingFlags.NonPublic);
        return (int) testFI.GetValue(null);
    }

    [Benchmark]
    public int ReflectionHelperTest()
    {
        return ReflectionHelper.GetField<ReflectionComparison, int>(nameof(testToGet));
    }

    [Benchmark]
    public int NoReflectionTest()
    {
        return testToGet;
    }
}