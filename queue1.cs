using System;
using System.Collections.Generic;

class program
{
  public static void Main()
  {
    Queue Q=new Queue(4);
  

    Q.Enqueue(100);
    Q.Enqueue(200);
    Q.Enqueue(300);
    Q.Enqueue(400);
    
   while(!Q.isEmpty())
   {
      System.Console.WriteLine("{0}", Q.Dequeue());
    }
  }
}
class Queue
{  
  private object [] a;
  private int front=0;
  private int rear=0;

  public  Queue (int n)
  {
    a=new object[n];
  }

  public void Enqueue(object x)
  {
      a[rear]=x;
      rear++;
  }

  public object Dequeue()
  {
    
    return a[front++];
  }

  public bool isEmpty()
  {
    return front==rear;
  }
}
