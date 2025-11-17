class program
{
  public static void Main()
  {
    List l;
    l=new List ();
   
    l.Add(100);
    l.Add(200);
    l.Add(300);
    l.Add(400);
    l.Add(500);
    l.Add(600);
    l.Add(700);
    l.Add(800);
    l.Add(900);
    l.Add(1000);

    l.print();
   }
 }
 class List 
  {
    private int []x;
   
   private int i;
   public List ()
   {
     x=new int[10];
    }
   public List (int num)
   {
      x=new int [num];
    }
    public void Add (int n)
    {
      if (i < x.Length)
       {
          x[i]=n;
          i++;
       }
   }
   public void print()
    {
      for(int i=0; i < x.Length; i++)
      {
        System.Console.WriteLine("{0}",x[i]);
       }
    }
}
