# Benchmarking

These are benchmarks related to Hollow Knight modding.

## Latest Benchmarks

### StringComparison

``` ini
BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2251/21H2/November2021Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT VectorSize=256
  DefaultJob : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT VectorSize=256
```
|                          Method |      Mean |    Error |   StdDev | Ratio | RatioSD |
|-------------------------------- |----------:|---------:|---------:|------:|--------:|
|              LinqFirstOrDefault | 250.24 ns | 4.901 ns | 6.709 ns |  8.14 |    0.32 |
| LinqFirstOrDefault_StringLength | 217.50 ns | 3.361 ns | 3.451 ns |  7.05 |    0.16 |
|                       LinqFirst | 234.26 ns | 4.569 ns | 4.488 ns |  7.60 |    0.20 |
|          LinqFirst_StringLength | 221.20 ns | 4.413 ns | 4.906 ns |  7.17 |    0.25 |
|                     ForeachLoop |  54.57 ns | 0.793 ns | 0.662 ns |  1.76 |    0.05 |
|        ForeachLoop_StringLength |  18.74 ns | 0.434 ns | 0.564 ns |  0.61 |    0.03 |
|                         ForLoop |  56.49 ns | 1.010 ns | 1.383 ns |  1.83 |    0.05 |
|            ForLoop_StringLength |  30.85 ns | 0.653 ns | 0.726 ns |  1.00 |    0.00 |

### FsmUtilBenchmark

``` ini
BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2251/21H2/November2021Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT VectorSize=256
  DefaultJob : .NET Framework 4.8 (4.8.4515.0), X64 RyuJIT VectorSize=256
```
|                                                              Method |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |
|-------------------------------------------------------------------- |----------:|----------:|----------:|----------:|------:|--------:|
|                                                    Fsm_Fsm_GetState |  6.275 μs | 0.0985 μs | 0.0822 μs |  6.245 μs |  1.48 |    0.02 |
|                                                 Fsm_FsmStates_First | 23.799 μs | 0.1196 μs | 0.1118 μs | 23.798 μs |  5.63 |    0.04 |
|                                    Fsm_FsmStates_First_StringLength | 24.557 μs | 0.1557 μs | 0.1300 μs | 24.552 μs |  5.81 |    0.04 |
|                                        Fsm_FsmStates_FirstOrDefault | 24.983 μs | 0.3390 μs | 0.2831 μs | 24.881 μs |  5.91 |    0.07 |
|                           Fsm_FsmStates_FirstOrDefault_StringLength | 25.706 μs | 0.2016 μs | 0.1574 μs | 25.697 μs |  6.08 |    0.04 |
|                                            Array_Find_Fsm_FsmStates | 13.519 μs | 0.2286 μs | 0.3052 μs | 13.376 μs |  3.19 |    0.07 |
|                               Array_Find_Fsm_FsmStates_StringLength | 13.901 μs | 0.2766 μs | 0.4696 μs | 13.841 μs |  3.30 |    0.11 |
|                                                   For_Fsm_FsmStates |  5.148 μs | 0.1023 μs | 0.1946 μs |  5.176 μs |  1.22 |    0.05 |
|                                      For_Fsm_FsmStates_StringLength |  4.808 μs | 0.0953 μs | 0.1484 μs |  4.719 μs |  1.13 |    0.04 |
|                           For_Fsm_FsmStates_StringLength_StateCache |  4.568 μs | 0.0379 μs | 0.0296 μs |  4.569 μs |  1.08 |    0.01 |
|                 For_Fsm_FsmStates_StringLength_StateCache_NameCache |  4.675 μs | 0.0240 μs | 0.0200 μs |  4.673 μs |  1.11 |    0.01 |
| For_Fsm_FsmStates_StringLength_StateCache_NameCache_NameLengthCache |  4.730 μs | 0.0359 μs | 0.0281 μs |  4.721 μs |  1.12 |    0.01 |
|                                    For_Unsafe_Pointer_Fsm_FsmStates |  5.633 μs | 0.0645 μs | 0.0571 μs |  5.623 μs |  1.33 |    0.01 |
|                       For_Unsafe_Pointer_Fsm_FsmStates_StringLength |  5.426 μs | 0.0730 μs | 0.0609 μs |  5.411 μs |  1.28 |    0.01 |
|                                   For_Fsm_FsmStates_HighPerformance |  4.686 μs | 0.0280 μs | 0.0219 μs |  4.693 μs |  1.11 |    0.01 |
|                      For_Fsm_FsmStates_HighPerformance_StringLength |  4.230 μs | 0.0126 μs | 0.0111 μs |  4.227 μs |  1.00 |    0.00 |
|                                     For_Fsm_FsmStates_56_1_Modified |  4.636 μs | 0.0925 μs | 0.1297 μs |  4.565 μs |  1.11 |    0.03 |
|                        For_Fsm_FsmStates_56_1_Modified_StringLength | 11.782 μs | 0.2258 μs | 0.2856 μs | 11.647 μs |  2.79 |    0.07 |
|                                     For_Fsm_FsmStates_56_2_Modified |  4.858 μs | 0.0959 μs | 0.1281 μs |  4.792 μs |  1.16 |    0.04 |
|                        For_Fsm_FsmStates_56_2_Modified_StringLength |  4.483 μs | 0.0878 μs | 0.0976 μs |  4.465 μs |  1.05 |    0.03 |
