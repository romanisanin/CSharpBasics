using System;
using System.Diagnostics;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] processes = GetProcessesList();

            Console.WriteLine("Enter process id or process name to kill the process");
            string proc = Console.ReadLine();
            if (Int32.TryParse(proc, out int value))
            {
                KillProccessById(value,processes);
            }
            else
            {
                KillProcessByName(proc,processes);
            }
        }


        static Process[] GetProcessesList()
        {
            Process[] processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                Console.WriteLine($"{process.Id} {process.ProcessName}");
            }
            return processes;
        }

        static void KillProcessByName(string processName, Process[] processes)
        {
            try
            {
                foreach (var process in processes)
                {
                    if (process.ProcessName == processName)
                        process.Kill();
                }
                CheckIfKilled(processes, processName);
                
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);    
            }
        }

        static void KillProccessById(int processId, Process[] processes)
        {
            try 
            { 
                foreach (var process in processes)
                {
                    if (process.Id == processId)
                    {
                        process.Kill();
                        processes = GetProcessesList();
                        CheckIfKilled(processes,processId);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }


        static void CheckIfKilled(Process[] processes, int processId)
        {
            int counter = 0;
            foreach (var process in processes)
            {
                if (process.Id == processId)
                {
                    counter++;
                    throw new Exception("Something went wrong");
                }
            }
            if (counter == 0)
            {
                Console.WriteLine($"The process id {processId} has been removed");
            }
        }

        static void CheckIfKilled(Process[] processes, string processName)
        {
            int counter = 0;
            foreach (var process in processes)
            {
                if (process.ProcessName == processName)
                {
                    counter++;
                    throw new Exception("Something went wrong");
                }
            }
            if (counter == 0)
            {
                Console.WriteLine($"The process name {processName} has been removed");
            }
        }
    }
}
//Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет завершить указанный процесс.
//Предусмотреть возможность завершения процессов с помощью указания его ID или имени процесса.
//В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.