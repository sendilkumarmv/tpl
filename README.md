The difference between `TaskFactory.StartNew(() => LongRunning())` and `var task = new Task(()=> LongRunning()); task.Start()` is only the control over when the task starts.

`var t = new Task(() => {} );`

`var t = new Task(() => {}, cancellationToken);`

`var t = new Task(() => {}, taskCreationOptions);`

`var t = new Task(() => {}, state);`

`var t = new Task(() => {}, state, taskCreationOptions);`
