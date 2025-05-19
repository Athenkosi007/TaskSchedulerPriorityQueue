# TaskSchedulerPriorityQueue

A simple C# console app demonstrating a custom **Priority Queue** for task scheduling. Tasks with higher priority are processed first.

## Features

- Add tasks with priority levels.
- Automatically sorts tasks based on priority.
- Processes and removes tasks in order of priority.

## Use Cases

- OS-level task scheduling.
- Job queues.
- Real-time systems.

## How It Works

Tasks are stored in a list and sorted after each insert based on priority (lower number = higher priority). When dequeuing, the highest-priority task is returned first.

