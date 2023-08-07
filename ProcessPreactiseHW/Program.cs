
using System.Diagnostics;

Run();

void Run() 
{ 
    while (true) 
    {
        Console.WriteLine("1.Get current process\n2.\n");

        string? input = null;

        input = Console.ReadLine();

        switch (input)
        {
            case "1":
                GetCurrentProcessName();
                break;
            case "2":

                break;
            case "3":

                break;
            case "4":

                break;
        }
    }
}


void GetCurrentProcessName() 
{
    try 
    {
        Process p = Process.GetCurrentProcess();
        Console.WriteLine($"\nOutput:\n{p.ProcessName}\n");
    }
    catch(Exception ex) 
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}



