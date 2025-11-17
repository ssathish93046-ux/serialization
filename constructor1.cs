class Myclass
{
  public Myclass(int val)
  {
    System.Console.WriteLine("{0}",val);
  }
 }
class program
{
 public static void Main()
   {
     Myclass mc;
    mc=new Myclass(5);
  }
}