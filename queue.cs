using System;
using System.Collections.Generic;

class program
{
  public static void Main()
  {
    List l=new List(4);
  

    l.Enqueue(100);
    l.Enqueue(200);
    l.Enqueue(300);
    l.Enqueue(400);
    
   while(!l.IsEmpty())
   {
      System.Console.WriteLine("{0}", l.Dequeue());
    }
  }
}
class List
{  
  private object [] item;
  private int front=0;
  private int rear=0;

  public  List (int n)
  {
   item=new object[n];
  }

  public void Enqueue(object val)
  {
      item[rear]=val;
      rear++;
  }

  public object Dequeue()
  {
    
    return item[front++];
  }

  public bool IsEmpty()
  {
    return front==rear;
  }
}
