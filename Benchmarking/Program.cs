using BenchmarkDotNet.Running;

namespace Benchmarking;

internal class Program
{
    public static void Main(string[] args)
    {
        //BenchmarkRunner.Run<StringComparison>();
        BenchmarkRunner.Run<FsmUtil.FsmUtilBenchmarkBase>();
    }
}

