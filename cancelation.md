# Cancellation of Tasks

https://medium.com/@mitesh_shah/a-deep-dive-into-c-s-cancellationtoken-44bc7664555f
<p>
When we execute long-running tasks, the system becomes very powerful, and overall throughput is high. However, there could be many 
scenarios when the tasks need to be canceled. That's where we can use the CancellationTokenSoure and CancellationToken.
</p>

1. CancellationTokenSource - This is the object responsible for creating a cancellation token and sending a cancellation request to all copies of that token.
2. CancellationToken - This is the structure used by listeners to monitor the token’s current state.

### Simple Implementation of task cancellation

* Instantiate a CancellationTokenSource object
* Pass the token returned by the CancellationTokenSource.Token property to each task or thread that listens for cancellation
* Provide a mechanism for each task or thread to respond to this cancellation
* Call the CancellationTokenSource.Cancel method to provide a notification for cancellation

https://github.com/sendilkumarmv/tpl/edit/master/action-cancelation-token.cs

### Points
* Cancellation is not forced. -> The important aspect here is that this model is cooperative, i.e., the cancellation is not forced on the listener. The listener can determine how to gracefully terminate in response to a cancellation request.
* Listeners(tasks) optionally throw an exception `OperationCancelledException`
* Once IsCancellationRequested is set as true when CancellationTokenSource's cancel method is called, it can't be set back to false. Hence token once cancelled can't be reused.

