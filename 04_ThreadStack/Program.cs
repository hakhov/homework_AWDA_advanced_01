int counter = 0;
ParameterizedThreadStart dele =new ParameterizedThreadStart( MyMethod)  ;
Thread thread = new Thread(dele);
thread.Start();
Thread.Sleep( 1000 );
Console.WriteLine($"Counter=>{counter}");