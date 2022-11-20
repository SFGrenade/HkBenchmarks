using System;
using BenchmarkDotNet.Attributes;
using Benchmarking.Creators;

namespace Benchmarking.FsmUtil;

public class FsmUtilBenchmarkBase
{
    protected readonly PlayMakerFSM[] Fsms = FsmCreator.CreateFsmArray();

    protected readonly string[] SearchStateName = FsmCreator.CreateFsmStateNameArray();

    protected int[] UseIndex = {};

    [GlobalSetup]
    public void Setup()
    {
        UseIndex = new int[Fsms.Length];
        for (int i = 0; i < Fsms.Length; i++)
        {
            UseIndex[i] = i;
        }
    }

    private void DoMethod<TMaybeNullable>(Func<PlayMakerFSM, string, TMaybeNullable> method)
    {
        for (int index = 0; index < UseIndex.Length; index++)
        {
            method(Fsms[index], SearchStateName[index]);
        }
    }

    [Benchmark]
    public void Fsm_Fsm_GetState() => DoMethod(FsmUtilGetMethods.Fsm_Fsm_GetState);

    [Benchmark]
    public void Fsm_FsmStates_First() => DoMethod(FsmUtilGetMethods.Fsm_FsmStates_First);
    
    [Benchmark]
    public void Fsm_FsmStates_First_StringLength() => DoMethod(FsmUtilGetMethods.Fsm_FsmStates_First_StringLength);
    
    [Benchmark]
    public void Fsm_FsmStates_FirstOrDefault() => DoMethod(FsmUtilGetMethods.Fsm_FsmStates_FirstOrDefault);
    
    [Benchmark]
    public void Fsm_FsmStates_FirstOrDefault_StringLength() => DoMethod(FsmUtilGetMethods.Fsm_FsmStates_FirstOrDefault_StringLength);
    
    [Benchmark]
    public void Array_Find_Fsm_FsmStates() => DoMethod(FsmUtilGetMethods.Array_Find_Fsm_FsmStates);
    
    [Benchmark]
    public void Array_Find_Fsm_FsmStates_StringLength() => DoMethod(FsmUtilGetMethods.Array_Find_Fsm_FsmStates_StringLength);
    
    [Benchmark]
    public void For_Fsm_FsmStates() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates);
    
    [Benchmark]
    public void For_Fsm_FsmStates_StringLength() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates_StringLength);
    
    [Benchmark]
    public void For_Fsm_FsmStates_StringLength_StateCache() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates_StringLength_StateCache);
    
    [Benchmark]
    public void For_Fsm_FsmStates_StringLength_StateCache_NameCache() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates_StringLength_StateCache_NameCache);
    
    [Benchmark]
    public void For_Fsm_FsmStates_StringLength_StateCache_NameCache_NameLengthCache() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates_StringLength_StateCache_NameCache_NameLengthCache);
    
    [Benchmark]
    public void For_Unsafe_Pointer_Fsm_FsmStates() => DoMethod(FsmUtilGetMethods.For_Unsafe_Pointer_Fsm_FsmStates);
    
    [Benchmark]
    public void For_Unsafe_Pointer_Fsm_FsmStates_StringLength() => DoMethod(FsmUtilGetMethods.For_Unsafe_Pointer_Fsm_FsmStates_StringLength);
    
    [Benchmark]
    public void For_Fsm_FsmStates_HighPerformance() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates_HighPerformance);
    
    [Benchmark(Baseline = true)]
    public void For_Fsm_FsmStates_HighPerformance_StringLength() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates_HighPerformance_StringLength);

    [Benchmark]
    public void For_Fsm_FsmStates_56_1_Modified() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates_56_1_Modified);

    [Benchmark]
    public void For_Fsm_FsmStates_56_1_Modified_StringLength() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates_56_1_Modified_StringLength);
    
    [Benchmark]
    public void For_Fsm_FsmStates_56_2_Modified() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates_56_2_Modified);
    
    [Benchmark]
    public void For_Fsm_FsmStates_56_2_Modified_StringLength() => DoMethod(FsmUtilGetMethods.For_Fsm_FsmStates_56_2_Modified_StringLength);
}
