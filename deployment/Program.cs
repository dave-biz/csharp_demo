﻿Console.WriteLine("Hello, from the C# Deployment Project!");

var sw = System.Diagnostics.Stopwatch.StartNew();

while (sw.Elapsed < TimeSpan.FromMinutes(1))
{
    Console.WriteLine("Sleeping ...");
    Thread.Sleep(TimeSpan.FromSeconds(5));
}
