using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DotNetSpan
{
    [MemoryDiagnoser]
    public class MyStack
    {
        [Params(10, 100)]
        public int Count { set; get; }

        [Benchmark]
        public void Alloc()
        {
            unsafe
            {
                var vals = stackalloc int[Count];
            }
        }

        [Benchmark]
        public void New()
        {
            var x = new int[Count];
        }
    }
}
