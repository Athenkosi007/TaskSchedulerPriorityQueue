using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskSchedulerPriorityQueue
{
    class TaskItem
    {
        public string Name { get; set; }
        public int Priority { get; set; } // 1 = High, 2 = Medium, 3 = Low
    }

    class PriorityQueue
    {
        private List<TaskItem> _tasks = new List<TaskItem>();

        public void Enqueue(TaskItem task)
        {
            _tasks.Add(task);
            _tasks = _tasks.OrderBy(t => t.Priority).ToList();
        }

        public TaskItem Dequeue()
        {
            if (_tasks.Count == 0) return null;
            var task = _tasks[0];
            _tasks.RemoveAt(0);
            return task;
        }

        public bool IsEmpty() => !_tasks.Any();
    }

    class Program
    {
        static void Main()
        {
            PriorityQueue queue = new PriorityQueue();

            queue.Enqueue(new TaskItem { Name = "Email client", Priority = 2 });
            queue.Enqueue(new TaskItem { Name = "Database backup", Priority = 1 });
            queue.Enqueue(new TaskItem { Name = "Generate report", Priority = 3 });

            Console.WriteLine("Processing Tasks Based on Priority:");
            while (!queue.IsEmpty())
            {
                var task = queue.Dequeue();
                Console.WriteLine($"Processing: {task.Name} [Priority {task.Priority}]");
            }
        }
    }
}
