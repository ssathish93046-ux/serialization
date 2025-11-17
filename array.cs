class Program
{
  public static void Main()
   {
     int [] x;
     int i;
    x=new int[5];
   for(i=0; i<x.Length; i++)
    {
      x[i]=int.Parse(System.Console.ReadLine());
     }
   for(i=0; i<x.Length; i++)
    {
     System.Console.WriteLine(x[i]);
     }
   }
  }