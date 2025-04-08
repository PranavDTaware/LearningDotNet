﻿using System;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Start two tasks in parallel
        Task task1 = Task.Run(() => DoWork("Task 1"));
        Task task2 = Task.Run(() => DoWork("Task 2"));

        // Wait for both tasks to complete
        Task.WhenAll(task1, task2).Wait();

        Console.WriteLine("Both tasks completed!");
    }

    static void DoWork(string taskName)
    {
        Console.WriteLine($"{taskName} is starting...");
        // Simulate some work with a delay
        Task.Delay(2000).Wait();
        Console.WriteLine($"{taskName} is finished!");
    }
}