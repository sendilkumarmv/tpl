# Cancellation of Tasks

https://medium.com/@mitesh_shah/a-deep-dive-into-c-s-cancellationtoken-44bc7664555f
<p>
When we execute long-running tasks, the system becomes very powerful, and overall throughput is high. However, there could be many 
scenarios when the tasks need to be canceled. That's where we can use the CancellationTokenSoure and CancellationToken.
</p>

* Instantiate a CancellationTokenSource object
* Pass the token returned by the CancellationTokenSource.Token property to each task or thread that listens for cancellation
* Provide a mechanism for each task or thread to respond to this cancellation
* Call the CancellationTokenSource.Cancel method to provide a notification for cancellation
