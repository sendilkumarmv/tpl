The difference between `TaskFactory.StartNew(() => LongRunning())` and `var task = new Task(()=> LongRunning()); task.Start()` is only the control over when the task starts.

## Constructors of `Task`

`var t = new Task(() => {} );`

`var t = new Task(() => {}, cancellationToken);`

`var t = new Task(() => {}, taskCreationOptions);`

TaskCreationOptions  - Most options are controlling the behavior of the task.
  1. None: The default option.
  2. PreferFairness: Indicates that task should be scheduled in a fair manner.
  3. LongRunning: Hints that the task will be a long-running, coarse-grained operation.
  4. AttachedToParent: Indicates that the task is attached to a parent in the task hierarchy.
  5. DenyChildAttach: Prevents child tasks from attaching to the current task.
  6. HideScheduler: Prevents the task from being scheduled by the default scheduler.
  7. RunContinuationsAsynchronously: Forces continuations added to the current task to be executed asynchronously.

e.g
```
Task task = new Task(() => {
    Console.WriteLine("Task running...");
}, TaskCreationOptions.LongRunning | TaskCreationOptions.PreferFairness);

task.Start();
task.Wait(); // Wait for the task to complete

Console.WriteLine("Task completed.");
```


`var t = new Task(() => {}, state);`

e.g
```
// Create and start a task with state
Task task = new Task((state) =>
{
    string message = (string)state;
    Console.WriteLine($"Task received message: {message}");
}, "Hello, Task!");

task.Start();
task.Wait(); // Wait for the task to complete

Console.WriteLine("Task completed.");
```

`var t = new Task(() => {}, state, cancellationToken);`

`var t = new Task(() => {}, state, taskCreationOptions);`

`var t = new Task(() => {}, state, cancellationToken, taskCreationOptions);`





