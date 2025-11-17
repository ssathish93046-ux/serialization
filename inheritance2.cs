class Parent 
{
 public Parent(int val)
 {
   System.Console.WriteLine("from Parent{0}",val);
 }

public Parent()
{
  System.Console.WriteLine("from parent");
}
}
class Child:Parent
{
 public Child(int val):base(val/2)
 {
   System.Console.WriteLine("from Child{0}",val);
 }
}
class Program
{
  public static void Main()
  {
    Parent p;
    Child c;
    p=new Parent(100);
    c=new Child(200);
   }
 }