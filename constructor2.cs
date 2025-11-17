class Myclass
{
  public Myclass(int val)
  {
    System.Console.WriteLine("Hello from Myclass {0}",val);
  }
  public Myclass()
  {
    System.Console.WriteLine("\nHello from Myclass" );
  }
 }
class program
{
 public static void Main()
   {
     Myclass mc;
    mc=new Myclass();
    mc=new Myclass(5);
  }
}