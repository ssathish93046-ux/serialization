// write find function, that checks the list with number, if it matches with the student id,it gives student. if it matches with the product id ,it gives product,else it gives null.

using System;
using System.Collections.Generic;

class Mybase
{
    public virtual void read()
    {
     
     }
    public virtual void print()
    {
    
    }
    public virtual int getId()  
    {
         return 0;
    }

}

class Student : Mybase
{
    private int sno;
    private string sname;
    private double fee;

    public override void read()
    {
        System.Console.WriteLine("Enter student no: ");
        sno = int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter student name: ");
        sname = Console.ReadLine();
        System.Console.WriteLine("Enter fee: ");
        fee = double.Parse( System.Console.ReadLine());
    }

    public override void print()
    {
         System.Console.WriteLine("Student ID: " + sno);
         System.Console.WriteLine("Student Name: " + sname);
         System.Console.WriteLine("Fee: " + fee);
    }

    public override int getId()
    {
        return sno;
    }
}

class Product : Mybase
{
    private int pid;
    private string pname;
    private double fee;

    public override void read()
    {
         System.Console.WriteLine("Enter product ID: ");
        pid = int.Parse(Console.ReadLine());
         System.Console.WriteLine("Enter product name: ");
        pname = Console.ReadLine();
         System.Console.WriteLine("Enter fee: ");
        fee = double.Parse( System.Console.ReadLine());
    }

    public override void print()
    {
         System.Console.WriteLine("Product ID: " + pid);
         System.Console.WriteLine("Product Name: " + pname);
         System.Console.WriteLine("Fee: " + fee);
    }

    public override int getId()
    {
        return pid;
    }
}

class List
{
    private Mybase[] items;
    private int i;

    public List(int n)
    {
        items = new Mybase[n];
        i = 0;
    }

    public void Add(Mybase obj)
    {
        items[i] = obj;
        i++;
    }

    public Mybase find(int id)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].getId() == id)
                return items[i];
        }
        return null;
    }
}

class Program
{
    public static void Main()
    {
        Product p = new Product();
        Student s = new Student();
        p.read();
        s.read();

        List lst = new List(2);
        lst.Add(p);
        lst.Add(s);

        Console.Write("Enter ID to search: ");
        int searchId = int.Parse(System.Console.ReadLine());
        Mybase m = lst.find(searchId);

        if (m == null)
        {
             System.Console.WriteLine("The given id is not present in the list.");
        }
        else
        {
            m.print();
        }
    }
}