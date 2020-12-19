using System;
using System.Threading.Tasks;

namespace Widgets
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Console.Out.WriteAsync("Hello Widgets with C# 9.0!");
            await Console.Out.WriteAsync("Hello widgets for Widget with C# 9.0!");
        }
    }
}