
using System.Diagnostics;

Run();

void Run() 
{ 
    while (true) 
    {
        Console.WriteLine("1.Get current process\n2.Find Process by name\n3.Start Visual Code process\n");

        string? input = null;

        input = Console.ReadLine();

        switch (input)
        {
            case "1":
                GetCurrentProcessName();
                break;
            case "2":
                FindProcessByName();
                break;
            case "3":
                StartProcessByName();
                break;
        }
    }
}


void GetCurrentProcessName() 
{
    try 
    {
        using Process p = Process.GetCurrentProcess();
        Console.WriteLine($"\nOutput:\n{p.ProcessName}\n");
    }
    catch(Exception ex) 
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

void FindProcessByName() 
{
    try { 
        string? processName = null;
    
        Console.WriteLine("Enter the process name: ");
        processName = Console.ReadLine();

        Process[] p = Process.GetProcessesByName(processName);

        foreach (Process proc in p)
        {
            Console.WriteLine($"{proc.Id} {proc.ProcessName} {proc.MachineName} {proc.BasePriority}\n");
        }
    }
    catch(Exception ex) 
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}

void StartProcessByName() 
{
    try
    {
        string? dir = "D:\\apps\\Microsoft VS Code\\Code.exe";

        using Process p = Process.Start(dir);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}