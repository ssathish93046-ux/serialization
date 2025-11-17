class List
 {
   private int []x;
 
  public void Init()
  {
    x=new int [10];
   System.Console.WriteLine(10);
   }
  
   public void Init(int size)
   {
     x=new int[size];
     System.Console.WriteLine(size);
    }
}
 class program
  {
     public static void Main()
     {
      List l;
      l=new List();
      l.Init();
 
      l.Init(6);
     }
  }