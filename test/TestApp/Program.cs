using System;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Console.Out.WriteAsync("Hello TestApp with C# 9.0!");
            await Console.Out.WriteAsync("Hello lowercccc for Widget with C# 9.0!");
        }
    }
}