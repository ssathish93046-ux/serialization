class Product 
{
    private int pid;
    private string pname;
    private double price;

    public   void read()
    {
       
        pid = int.Parse(System.Console.ReadLine());
        pname = System.Console.ReadLine();
        price = double.Parse( System.Console.ReadLine());
    }
    
    public override string ToString()
    {
       
      return string.Format("{0} {1} {2} ",pid, pname, price);


    }
}

class Student 
{
    private int Sno;
    private string Sname;
    private double fee;

    public    void read()
    {
     
        Sno = int.Parse(System.Console.ReadLine());
        Sname = System.Console.ReadLine();
        fee = double.Parse( System.Console.ReadLine());
    }
    public override string ToString()
    {
      
      return string.Format("{0} {1} {2}",Sno, Sname, fee);

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
  object currentItem=items[j];
  j++;
  return currentItem;
 }

 public virtual string ToString()
 { 
   return ("object items[i]");
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
         object currentItem=l.get( );

         System.Console.WriteLine(currentItem.ToString());
       
    }
 }
}



