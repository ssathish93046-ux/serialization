class Generic <T>
{
  private T data;
  public Generic (T value)
  {
     data=value;
  }
  public void setData (T value)
  {
    data=value;
  }
  public T getData()
  {
    return (data);
  }
}
 
class Program
{
  public static void Main()
  {
    Generic <int> Gi;
    Generic <double> Gd;
    Generic <string> Gf;
    Generic <object> Go;
    
   Gi=new Generic <int> (100);
   Gd=new Generic <double> (22.22);
   Gi.setData(1500);
   Gd.setData(22.22);
 
   System.Console.WriteLine(Gi.getData());
   System.Console.WriteLine(Gxd.getData());
  }
}

    

