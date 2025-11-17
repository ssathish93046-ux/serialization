using System;
using System.Collections.Generic;


class Program
{
    public static void Main()
    {
        List l = new List(3);
        

        l.Add(100);
        l.Add(20);
        l.Add(10);

        System.Console.WriteLine("Linked List contents:");
        l.print();
    }
}
 

class Node
{
   public object data;
   public Node next;

   public Node(object val)
   {
     data=val;
     next=null;
    }
  }


class List
{
  private Node data;
  private Node next;
    
  public List(int size)
  {
    data=null;
    next=null;
   }
   public void Add(object val)
   {
       Node nw= new Node(val);

      if(data==null)
      {
        data=nw;
        next=nw;
       }
       else
       {
         next.next=nw;
         next=nw;
        }
   }
  public void print()
  {
    Node temp=data;

    while(temp!=null)
    {
      System.Console.WriteLine(temp.data);
      temp=temp.next;
     }
   }
}

        
