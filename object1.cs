class parent
{
 
    public virtual void print()
    {
     System.Console.WriteLine("print parent");   
     }   
}

class student:parent
{
	private int sid;
	private string sname;
	private double fee;

        public void read()
        {
          System.Console.WriteLine("Enter student ID: ");
          sid = int.Parse(System.Console.ReadLine());
          System.Console.WriteLine("Enter student name: ");
          sname = System.Console.ReadLine();
          System.Console.WriteLine("Enter fee: ");
          fee = double.Parse( System.Console.ReadLine());
        }
       public override void print()
       {
          System.Console.WriteLine("{0} {1} {2} ",sid,sname,fee);
       }

}
class Product : parent
{
    private int pid;
    private string pname;
    private double price;

    public  void read()
    {
        System.Console.WriteLine("Enter product ID: ");
        pid = int.Parse(System.Console.ReadLine());
        System.Console.WriteLine("Enter product name: ");
        pname = System.Console.ReadLine();
        System.Console.WriteLine("Enter price: ");
        price = double.Parse( System.Console.ReadLine());
    }
    public override void print()
    {
        System.Console.WriteLine("{0} {1} {2} ",pid,pname,price);
    }

}
class List
{
    private object[]items;
    private int i;

    public List(int n)
    {
        items= new object[n];
        i=0;
    }

    public void Add(object obj)
    {
        items[i] = obj;
        i++;
    }
  public object get(int i)
  {
    return items[i--];
   }

}
class Program
{
    public static void Main()
    {
        Product p = new Product();
        student s = new student();
        p.read();
        s.read();

        List l= new List(5);
        l.Add(p);
        l.Add(s);
        l.Add(100);
        l.Add("ravi");
        l.Add(4500.22);
       
      for (int i=0; i<5; i++)
      {
         object obj = l.get(i);

         if( obj is student)
         {
           (obj as student).print();
	 }
	else if(obj is Product)
 	{
	   (obj as Product).print();
	}
	else
	{
	   System.Console.WriteLine(obj);
	}
       }
     }
 }