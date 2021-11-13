using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            while (true)
            {
                IList<ToDo> toDoList = ReadJson();
                Console.WriteLine("");
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Change Task Status");
                Console.WriteLine("2. Show All Tasks");
                Console.WriteLine("3. Close The Program");

                Console.WriteLine("Enter Menu Item:");
                if (Int32.TryParse(Console.ReadLine(), out int menuitem))
                {
                    switch (menuitem)
                    {
                        case 1:
                            ChangeTask(toDoList);
                            break;
                        case 2:
                            Console.Clear();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            continue;
                    }
                }
            }
        }

        private static IList<ToDo> ReadJson()
        {
            StreamReader r = new StreamReader("tasks.json");
            string jsonArray = r.ReadToEnd();
            var tasks = JsonSerializer.Deserialize<IList<ToDo>>(jsonArray);
            Print(tasks);
            r.Dispose();
            r.Close();
            return tasks;
        }

        private static void Print(IList<ToDo> tasks)
        {
            int i = 0;
            foreach (var task in tasks)
            {
                i++;
                if (task.IsDone)
                {
                    Console.WriteLine($"{i}.[x]     {task.Title}");
                }
                else
                {
                    Console.WriteLine($"{i}.[ ]     {task.Title}");
                }
            }
        }

        private static void ChangeTask(IList<ToDo> toDos)
        {
            while (true)
            {
                Console.Clear();
                Print(toDos);
                Console.WriteLine("Enter a Task Number to Change Status:");
                if (Int32.TryParse(Console.ReadLine(), out int taskNumber))
                {
                    
                    if (taskNumber >= 1 || taskNumber <= toDos.Count)
                    {
                        taskNumber--;
                        if (toDos[taskNumber].IsDone)
                        {
                            toDos[taskNumber].IsDone = false;
                        }
                        else
                        {
                            toDos[taskNumber].IsDone = true;
                        }
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            
            string json = JsonSerializer.Serialize<IList<ToDo>>(toDos);
            File.WriteAllText("tasks.json", json);

            Console.Clear();
            Menu();
        }
    }
}
/*(*) Список задач (ToDo-list):
написать приложение для ввода списка задач;
задачу описать классом ToDo с полями Title и IsDone;
на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
если задача выполнена, вывести перед её названием строку «[x]»;
вывести порядковый номер для каждой задачи;
при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
записать актуальный массив задач в файл tasks.json/xml/bin.
*/