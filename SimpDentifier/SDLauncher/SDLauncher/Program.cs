using System;
using System_Diagnostics;

namespace System_Diagnostics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Launching SimpDentifier Version 1.2.4.1\n");
            ConsoleColor color = Console.ForegroundColor;
            System.Diagnostics.ProcessStartInfo startinfo = new System.Diagnostics.ProcessStartInfo(@"C:\Users\Chandler.Boots_PC\Desktop\SimpDentifier\SimpDentiier 1.2\SimpDentiier 1.2\bin\Debug\netcoreapp3.1\SimpDentifier 1.2.exe");
            startinfo.CreateNoWindow = false;
            startinfo.UseShellExecute = false;
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(startinfo);
            Console.ReadLine();
            p.WaitForExit();
            Console.ForegroundColor = color;
        }
    }
}
