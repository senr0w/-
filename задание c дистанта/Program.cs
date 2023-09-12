using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            Console.Write("Введите команду: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    Console.Write("Введите задачу: ");
                    string task = Console.ReadLine();
                    AddTask(task);
                    break;

                case "2":
                    Console.Write("Введите номер задачи для удаления (от 1 до " + tasks.Count + "): ");
                    int removeIndex = int.Parse(Console.ReadLine()) - 1;
                    RemoveTask(removeIndex);
                    break;

                case "3":
                    Console.Write("Введите номер задачи для пометки как выполненной (от 1 до " + tasks.Count + "): ");
                    int markIndex = int.Parse(Console.ReadLine()) - 1;
                    MarkTaskDone(markIndex);
                    break;

                case "4":
                    Console.WriteLine("Завершение работы приложения.");
                    return;

                default:
                    Console.WriteLine("Неизвестная команда.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Список задач:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список пуст");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + tasks[i]);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Для добавления задачи введите команду: 1");
        Console.WriteLine("Для удаления задачи введите команду: 2");
        Console.WriteLine("Для пометки задачи как выполненной введите команду: 3");
        Console.WriteLine("Для выхода из приложения введите команду: 4");
        Console.WriteLine();
    }

    static void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine("Задача добавлена: " + task);
    }

    static void RemoveTask(int index)
    {
        if (index < 0 || index >= tasks.Count)
        {
            Console.WriteLine("Ошибка: неверный номер задачи");
            return;
        }

        string removedTask = tasks[index];
        tasks.RemoveAt(index);
        Console.WriteLine("Задача удалена: " + removedTask);
    }

    static void MarkTaskDone(int index)
    {
        if (index < 0 || index >= tasks.Count)
        {
            Console.WriteLine("Ошибка: неверный номер задачи");
            return;
        }

        string markedTask = tasks[index];
        tasks[index] = "Выполнено: " + tasks[index];
        Console.WriteLine("Задача выполнена: " + markedTask);
    }
}
