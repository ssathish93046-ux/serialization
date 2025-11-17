class MyForm: System.Windows.Forms.Form
{
   private System.Windows.Forms.TextBox tb1,tb2,tb3;
   private System.Windows.Forms.Button btn;

   private void do_sum(System.Object o,System.EventArgs e)
   {
      tb3.Text=(int.Parse(tb1.Text)+ int.Parse(tb2.Text)).ToString();
   }

   public MyForm()
   {
      tb1=new System.Windows.Forms.TextBox();
      tb1.Location=new System.Drawing.Point(100,100); 
      
      tb2=new System.Windows.Forms.TextBox();
      tb2.Location=new System.Drawing.Point(100,150); 

      tb3=new System.Windows.Forms.TextBox();
      tb3.Location=new System.Drawing.Point(100,200); 

      btn=new System.Windows.Forms.Button();
      btn.Text="Sum";
      btn.Click+=new System.EventHandler(do_sum);
      btn.Location=new System.Drawing.Point(100,250);
     

      Controls.Add(tb1);
      Controls.Add(tb2);
      Controls.Add(tb3);
      Controls.Add(btn);
   }
}


class program
{
   public static void Main(string []args)
   {
      MyForm frm=new MyForm();
      System.Windows.Forms.Application.Run(frm);
    }
}

     
 	
