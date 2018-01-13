using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DotNetSpan
{
    [MemoryDiagnoser]
    public class MySpan
    {
        private string Text;

        [Params(10, 100)]
        public int CharacterCount { get; set; }

        [GlobalSetup]
        public void Setup() => Text = new String(Enumerable.Repeat('a', CharacterCount).ToArray());

        [Benchmark]
        public string Substring() => Text.Substring(0, Text.Length / 2);

        [Benchmark]
        public ReadOnlySpan<char> Slice() => Text.AsSpan().Slice(0, Text.Length / 2);
    }
}
