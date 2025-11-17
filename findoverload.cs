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

   System.Console.Write("Enter ID to search: ");
    int id = int.Parse(System.Console.ReadLine());

 Product t= l.find( id);
 
  if (t != null)
   {
     t.print();
    }
  
   else
   {
     System.Console.WriteLine("Product not found");
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
    public int getId()
    {
      return pid;
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
public Product find (int id)
{
  for(int j=0; j < i; j++)
   {
     if (products[j].getId() == id)
      {
        return products[j];
       }
    }
   return null; 
 }
   
  public Product get(int i)
  {
   
    return products[i];
   }

}
