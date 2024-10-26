public static class Tasks
{
      private CancellationTokenSource source = new CancellationTokenSource();
      private void button2_Click(object sender, EventArgs e)
      {
          if(source.IsCancellationRequested)
          {
              source = new CancellationTokenSource();
          }
          var token = source.Token;
          var task = new Task(() => DoCancelableWork("You can cancel me!!!", 1000), token);
          task.Start();
          button2.Enabled = false;
          btnCancelTasks.Enabled = true;
      }

      public void DoCancelableWork(string value, int delay)
      {
          while (true)
          {
              this.Invoke(new Action(() => { textBox1.Text += $"{value} | "; }));
              Thread.Sleep(delay);
              if(source.IsCancellationRequested)
              {
                  break;
              }
          }
      }

      private void btnCancelTasks_Click(object sender, EventArgs e)
      {
          source.Cancel();
          button2.Enabled = true;
          btnCancelTasks.Enabled = false;
      }
}
}
