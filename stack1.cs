using System;
using System.Collections.Generic;

class program
{
  public static void Main()
  {
    stack s=new stack(4);
    

    s.push(100);
    s.push(200);
    s.push(300);
    s.push(400);

   while(!s.isEmpty())
   {
     System.Console.WriteLine(s.Pop());
   }
  }
}
class stack
{  
  private object [] a;
  private int top;

  public  stack(int n)
  {
   a=new object[n];
   top=-1;
  }

  public void push(object x)
  {
       top++;
      a[top]=x;
      
  }

  public object Pop()
  {
  
    return a[top--];
  }
  public bool isEmpty()
  {
    return top==-1;
  }
}
 