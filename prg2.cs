class Program
{
 public static void Main()
 {
   int c, cpp, java;
   c=int.Parse(System.Console.ReadLine());
   cpp=int.Parse(System.Console.ReadLine());
   java=int.Parse(System.Console.ReadLine());
   System.Console.WriteLine(c+cpp+java);
  System.Console.WriteLine("average");
   System.Console.WriteLine((c + cpp + java)/3);

   if((c + cpp + java)/3 > 40)
   {
     System.Console.WriteLine("c grade");
    }
    else if((c + cpp + java)/3 > 80)
    {
      System.Console.WriteLine("a grade");
     }
    else if((c + cpp + java)/3 < 30)
      {
        System.Console.WriteLine("fail");
       }
  }
}