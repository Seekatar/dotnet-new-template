using System;
using System.Threading.Tasks;

namespace zzzProjectNamezzz
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Console.Out.WriteAsync("Hello zzzProjectNamezzz with C# 9.0!");
            await Console.Out.WriteAsync("Hello zzzProjectNameLowerzzz for $company$ with C# 9.0!");
        }
    }
}