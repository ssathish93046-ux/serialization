class Parent 
{
 public Parent()
 {
   System.Console.WriteLine("from Parent");
 }
}
class Child:Parent
{
 public Child()
 {
   System.Console.WriteLine("from Child");
 }
}
class Program
{
  public static void Main()
  {
    Parent p;
    Child c;
    p=new Parent();
    c=new Child();
   }
 }