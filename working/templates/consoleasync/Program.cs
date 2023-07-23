using System;
using System.Threading.Tasks;

namespace zzzProjectNamezzz
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Console.Out.WriteAsync("Hello project: 'zzzProjectNamezzz'");
            await Console.Out.WriteAsync("Hello project all lc: 'zzzprojectnamezzz'");
            await Console.Out.WriteAsync("Hello project all uc: 'ZZZPROJECTNAMEZZZ'");
            await Console.Out.WriteAsync("Hello projectLower: 'zzzProjectNameLowerzzz' for $company$");
            await Console.Out.WriteAsync("Port is: '44345'");
        }
    }
}