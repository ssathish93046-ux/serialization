namespace nm1
{

  delegate void Mydelegate (string name);

    class MyForm1: System.Windows.Forms.Form
    {
       private System.Windows.Forms.TextBox tb1;
       private System.Windows.Forms.Button btn;

       public Mydelegate md1;                


       private void btn_click(System.Object o,System.EventArgs e)
       {
           MyForm2 frm2=new MyForm2();
           frm2.md2=Text1;            
           md1=frm2.Text2;            
           md1(tb1.Text);  
           frm2.Show();
           tb1.Text = "";
           
       }
       public void Text1(string name)
       {
          tb1.Text = name;
      
       }  

       public MyForm1()
       {
          Text="MyForm1"; 
          
          tb1=new System.Windows.Forms.TextBox();
          tb1.Location=new System.Drawing.Point(100,100); 
      
          btn=new System.Windows.Forms.Button();
          btn.Text="ok";
          btn.Click+=new System.EventHandler(btn_click);
          btn.Location=new System.Drawing.Point(100,200);
     

          Controls.Add(tb1);
          Controls.Add(btn);
       }
    }
    class MyForm2: System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Button btn;

        public Mydelegate md2;

        private void btn_click(System.Object o,System.EventArgs e)
        {
            md2(tb2.Text);
            tb2.Text="";
      
        }
        public void Text2(string name)
        {
          
             tb2.Text = name;     
         }      
            

        public MyForm2()
        {
           Text="MyForm2";

           tb2=new System.Windows.Forms.TextBox();
           tb2.Location=new System.Drawing.Point(100,100); 
      
           btn=new System.Windows.Forms.Button();
           btn.Text="ok";
           btn.Click+=new System.EventHandler(btn_click);
           btn.Location=new System.Drawing.Point(100,200);
     

           Controls.Add(tb2);
           Controls.Add(btn);
        }
    }
 

  class program
  {
      public static void Main(string []args)
      {
          MyForm1 frm1=new MyForm1();
          System.Windows.Forms.Application.Run(frm1);
     
     
      
     }
  }
}

     
 	
