class Product 
{
    private int pid;
    private string pname;
    private double price;

    public   void read()
    {
         System.Console.WriteLine("Enter product ID: ");
        pid = int.Parse(System.Console.ReadLine());
         System.Console.WriteLine("Enter product name: ");
        pname = System.Console.ReadLine();
         System.Console.WriteLine("Enter price: ");
        price = double.Parse( System.Console.ReadLine());
    }

    public   void print()
    {
         System.Console.WriteLine("Product ID: " + pid);
         System.Console.WriteLine("Product Name: " + pname);
         System.Console.WriteLine("Price: " + price);
    }
    public override string ToString()
    {
       return "Product: {pid}  Product Name: {pname}  Price: {price}";
    }
}

class Student 
{
    private int Sno;
    private string Sname;
    private double fee;

    public    void read()
    {
         System.Console.WriteLine("Enter Student Sno: ");
        Sno = int.Parse(System.Console.ReadLine());
         System.Console.WriteLine("Enter Student name: ");
        Sname = System.Console.ReadLine();
         System.Console.WriteLine("Enter fee: ");
        fee = double.Parse( System.Console.ReadLine());
    }

    public  void print()
    {
         System.Console.WriteLine("Student: " + Sno);
         System.Console.WriteLine("Student Name: " + Sname);
         System.Console.WriteLine("Fee: " + fee);
    }
    public override string ToString()
    {
       return "Student: {Sno} Student Name: {Sname}  Fee: {fee}";

    }

}
class List
{
  private object [] items;
  private int i;
  private int j;

  public void Init( int n)
  {
    items =new object[n];
    i=0;
    j=0;
  }
  public void Add(object x)
  {
    items[i]=x;
    i++;
   }
 public object get()
 {
  object current=items[j];
  j++;
  return current;
 }
}
class Program
 {
   public static void Main()
    {
      List l=new List();
      l.Init(5);

     Product p=new Product();
     p.read();
     Student s=new Student();
     s.read();

     l.Add(p);
     l.Add(s);
     l.Add(100);  
     l.Add("ravi");
     l.Add(50.22);

   for (int i=0; i<5; i++)
   {
     object current = l.get();

      if(current is Product)
      {
       (( Product)current).print();
      }
      else if(current is Student)
       {
         ((Student)current).print();
       }
      else
       {
         System.Console.WriteLine(current);
       }
    }
 }
}



