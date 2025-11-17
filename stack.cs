using System;
using System.Collections.Generic;

class program
{
  public static void Main()
  {
    List l=new List(4);
    

    l.Push(100);
    l.Push(200);
    l.Push(300);
    l.Push(400);
    
   while(!l.IsEmpty())
   {
      System.Console.WriteLine(l.Pop());
    }
  }
}
class List
{  
  private object [] item;
  private int top;

  public  List(int n)
  {
   item=new object[n];
   top=-1;
  }

  public void Push(object x)
  {
      top++;
      item[top]=x;
  }

  public object Pop()
  {
  
    return item[top--];
  }

  public bool IsEmpty()
  {
   return top==-1;
  }
}
 