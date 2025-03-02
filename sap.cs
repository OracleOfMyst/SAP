using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;

namespace SAP
{
    internal class Program
    {
        static void SAP()
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();

            runspace.Open();

            PowerShell ps = PowerShell.Create();
            ps.Runspace = runspace;

            Console.WriteLine("");
            Console.Write("[SAP CONSOLE] ~ ");
            string op = Console.ReadLine();
            ps.AddScript(op);
            Collection<PSObject> results = ps.Invoke();
            foreach (PSObject obj in results)
            {
                Console.WriteLine(obj.ToString());
            }
            runspace.Close();
        }

        static void Main()
        {
            Console.WriteLine("");
            Console.WriteLine("  /$$$$$$   /$$$$$$  /$$$$$$$ ");
            Console.WriteLine("  /$$__  $$ /$$__  $$| $$__  $$");
            Console.WriteLine(" | $$  \\__/| $$  \\ $$| $$  \\ $$");
            Console.WriteLine(" |  $$$$$$ | $$$$$$$$| $$$$$$$/");
            Console.WriteLine("  \\____  $$| $$__  $$| $$____/ ");
            Console.WriteLine("  /$$  \\ $$| $$  | $$| $$      ");
            Console.WriteLine(" |  $$$$$$/| $$  | $$| $$      ");
            Console.WriteLine("  \\______/ |__/  |__/|__/      ");
            Console.WriteLine("");
            Console.WriteLine("[?] Developed by OracleOfMyst [?]");
            Console.WriteLine("");
            while (true)
            {
                try
                {
                    SAP();
                }
                catch (Exception e) { }
            }
        }
    }
}
