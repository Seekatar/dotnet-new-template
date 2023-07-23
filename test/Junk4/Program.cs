using System;
using System.Threading.Tasks;

namespace Junk4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Console.Out.WriteAsync("Hello project: 'Junk4'");
            await Console.Out.WriteAsync("Hello project all lc: 'junk4'");
            await Console.Out.WriteAsync("Hello project all uc: 'ZZZPROJECTNAMEZZZ'");
            await Console.Out.WriteAsync("Hello projectLower: 'junk4' for My Company");
            await Console.Out.WriteAsync("Port is: '58315'");
        }
    }
}