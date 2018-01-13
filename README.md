## Span

```
BenchmarkDotNet=v0.10.11, OS=macOS 10.13.2 (17C88) [Darwin 17.3.0]
Processor=Intel Core i5-3210M CPU 2.50GHz (Ivy Bridge), ProcessorCount=4
.NET Core SDK=2.1.2
  [Host]     : .NET Core 2.0.3 (Framework 4.6.0.0), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.0.0), 64bit RyuJIT


    Method | CharacterCount |      Mean |     Error |    StdDev |  Gen 0 | Allocated |
---------- |--------------- |----------:|----------:|----------:|-------:|----------:|
 Substring |             10 |  19.51 ns | 0.5106 ns | 1.1207 ns | 0.0254 |      40 B |
     Slice |             10 |  12.55 ns | 0.2870 ns | 0.2947 ns |      - |       0 B |
 Substring |           1000 | 152.84 ns | 3.3519 ns | 3.1354 ns | 0.6557 |    1032 B |
     Slice |           1000 |  12.61 ns | 0.3145 ns | 0.2942 ns |      - |       0 B |


 Method | Count |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
------- |------ |-----------:|----------:|----------:|-------:|----------:|
  Alloc |    10 |  0.0122 ns | 0.0182 ns | 0.0170 ns |      - |       0 B |
    New |    10 |  6.2181 ns | 0.0900 ns | 0.0798 ns | 0.0203 |      64 B |
  Alloc |   100 |  0.0335 ns | 0.0269 ns | 0.0252 ns |      - |       0 B |
    New |   100 | 22.2011 ns | 0.4732 ns | 0.8288 ns | 0.1348 |     424 B |
```