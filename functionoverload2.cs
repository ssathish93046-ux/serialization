class Program
 {
   public static void Main()
    {
      List l=new List();
      l.Init(3);
     Product p1=new Product();
      Product p2=new Product();
       Product p3=new Product();
     p1.read();
     p2.read();
     p3.read();
    l.Add(p1);
     l.Add(p2);
     l.Add(p3);
   for (int i=0; i<3; i++)
   {
      Product P = l.get(i);
       P.print();
   }
 }
}
 



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

    public void print()
    {
         System.Console.WriteLine("Product ID: " + pid);
         System.Console.WriteLine("Product Name: " + pname);
         System.Console.WriteLine("Price: " + price);
    }
}
class List
 {
   private Product[] products;
   private int i;

 
  public void Init()
  {
    products=new Product [10];
   
   }
  
   public void Init(int size)
   {
     products=new Product[size];

    }
 public void Add(Product p)
    {
        products[i] = p;
        i++;
    }
  public Product get(int i)
  {
   i++;
    return products[i];
   }
}
