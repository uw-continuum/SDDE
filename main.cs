using System;

class MainClass {
  public static void Main (string[] args) {
    var watch = new System.Diagnostics.Stopwatch();
    //Start the timer        
    watch.Start();

    //Perform your code
    for (int i = 0; i < 1000; i++)
    {
      Console.Write(i);
    }
    
    //End the timer
    watch.Stop();
    
    Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    
  }
}
