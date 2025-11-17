

class items
{
 
    public virtual void print()
    {
     System.Console.WriteLine("base item");   
     }   
}

class Student : items
{
    private int sno; 2
    private string sname;
    private double fee;

    public void read()
    {
        System.Console.WriteLine("Enter student no: ");
        sno = int.Parse(System.Console.ReadLine());
         System.Console.WriteLine("Enter student name: ");
        sname = System.Console.ReadLine();
        System.Console.WriteLine("Enter fee: ");
        fee = double.Parse( System.Console.ReadLine());
    }

    public override void print()
    {
         System.Console.WriteLine("Student ID: " + sno);
         System.Console.WriteLine("Student Name: " + sname);
         System.Console.WriteLine("Fee: " + fee);
    }
}

class Product : items
{
    private int pid;
    private string pname;
    private double fee;

    public  void read()
    {
         System.Console.WriteLine("Enter product ID: ");
        pid = int.Parse(System.Console.ReadLine());
         System.Console.WriteLine("Enter product name: ");
        pname = System.Console.ReadLine();
         System.Console.WriteLine("Enter fee: ");
        fee = double.Parse( System.Console.ReadLine());
    }

    public override void print()
    {
         System.Console.WriteLine("Product ID: " + pid);
         System.Console.WriteLine("Product Name: " + pname);
         System.Console.WriteLine("Fee: " + fee);
    }
}

class List
{
    private object[] listItems;
    private int i;

    public List(int n)
    {
        listItems= new object[n];
        i = 0;
    }

    public void Add(object obj)
    {
        listItems[i] = obj;
        i++;
    }
  public object get(int i)
  {
    return listItems[i];
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

      for (int i=0; i<2; i++)
      {
         object obj = lst.get(i);
         ((items)obj).print();
       }
     }
 }

  


   