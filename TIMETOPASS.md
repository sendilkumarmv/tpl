* It is required to wait by nature if it takes more time to complete.
* `Thread.Sleep(int timeInMilliSecond)`
  1. Sleep pauses the thread to execute this code, and notifies the scheduler to allow another thread to execute.
  2. It is synchronous, it blocks the current thread.
 
* `Task.Delay(int timein MilliSecond)`
  1. Creates a task that is completed after a specified time. It is used to introduce an asynchronous delay.
  2. It’s non-blocking, so the calling thread can continue executing other code while the delay is in effect.
