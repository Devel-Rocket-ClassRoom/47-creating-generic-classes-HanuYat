using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== int 큐 (용량: 3) ===");
var intQueue = new SimpleQueue<int>(3);
Console.WriteLine("Enqueue: 10, 20, 30");
intQueue.Enqueue(30);
intQueue.Enqueue(20);
intQueue.Enqueue(10);

Console.WriteLine($"Count: {intQueue.Count}, IsFull: {intQueue.IsFull}");
intQueue.Enqueue(40);
Console.WriteLine($"Peek: {intQueue.Peek()}");

Console.WriteLine("Dequeue: 10");
intQueue.Dequeue();
Console.WriteLine("Dequeue: 20");
intQueue.Dequeue();

Console.WriteLine($"Count: {intQueue.Count}, IsEmpty: {intQueue.IsEmpty}");
Console.WriteLine();

Console.WriteLine("=== string 큐 (용량: 2) ===");
var stringQueue = new SimpleQueue<string>(2);
Console.WriteLine("Enqueue: Hello, World");
stringQueue.Enqueue("World");
stringQueue.Enqueue("Hello");


Console.WriteLine("Dequeue: Hello");
stringQueue.Dequeue();
Console.WriteLine("Dequeue: World");
stringQueue.Dequeue();
stringQueue.Dequeue();
Console.WriteLine("Dequeue:");
Console.WriteLine($"IsEmpty: {stringQueue.IsEmpty}");