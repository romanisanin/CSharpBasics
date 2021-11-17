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
                Console.WriteLine("1. Add a  New Task");
                Console.WriteLine("2. Change Task Status");
                Console.WriteLine("3. Show All Tasks");
                Console.WriteLine("4. Close The Program");

                Console.WriteLine("Enter Menu Item:");
                if (Int32.TryParse(Console.ReadLine(), out int menuitem))
                {
                    switch (menuitem)
                    {
                        case 1:
                            AddTask(toDoList);
                            break;
                        case 2:
                            ChangeTask(toDoList);
                            break;
                        case 3:
                            Console.Clear();
                            break;
                        case 4:
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

        private static void AddTask(IList<ToDo> toDos)
        {
            ToDo task = new ToDo();
            
            Console.Clear();
            Console.WriteLine("Enter a new ask:");
            task.Title = Console.ReadLine();
            Console.WriteLine("Enter a task status 1 - completed, 0 - not completed:");
            int status = Int32.Parse(Console.ReadLine());
            if (status == 1)
            {
                task.IsDone = true;
            }
            else
            {
                task.IsDone= false;
            }

            toDos.Add(task);
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