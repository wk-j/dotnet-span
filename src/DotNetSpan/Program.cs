using System.Collections;
using BenchmarkDotNet.Running;

namespace DotNetSpan
{

    class Program
    {
        static void Main(string[] args)
        {
            // BenchmarkRunner.Run<Test>();
            BenchmarkRunner.Run<MyStack>();
        }
    }
}
