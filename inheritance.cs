class Math2024
{
  public int Sum(int x, int y)
  {
   return(x+y);
  }
  protected int subt(int x, int y)
  {
    return(x-y);
  }
}
class Math2025:Math2024
{
  public int mult(int x, int y)
  {
    return(x*y);
  }

  public int subtract(int x, int y)
  {
    return(subt (x,y));
  }
}
class Program
{
  public static void Main()
  {
    Math2024 m1;
    Math2025 m2;
    m1=new Math2024();
    m2=new Math2025();
    System.Console.WriteLine(m1.Sum(100,200));
    System.Console.WriteLine(m2.Sum(50,20));
    System.Console.WriteLine(m2.subtract(200,100));
    System.Console.WriteLine(m2.mult(50,20));
  }
}

