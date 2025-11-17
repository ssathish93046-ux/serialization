
public delegate void TextChangedDelegate(string str);

public class MyForm1:System.Windows.Forms.Form 
{
	private System.Windows.Forms.TextBox tb1;
	private System.Windows.Forms.Button btn;

	public MyForm1()
	{
		Text="MyForm1";

		tb1=new System.Windows.Forms.TextBox();
		tb1.Location = new System.Drawing.Point(100,150);
		btn = new System.Windows.Forms.Button();
	        btn.Text = "Ok";
	        btn.Location = new System.Drawing.Point(100, 200);
 	        btn.Click += new System.EventHandler(btn_Click);

	        Controls.Add(tb1);
        	Controls.Add(btn);
	}
	public void btn_Click(System.Object o, System.EventArgs e)
   	{
        	MyForm2 frm2 = new MyForm2();
		frm2.TbText=tb1.Text;
		frm2.tcd+=new TextChangedDelegate(txt_changed);       
        	
        	frm2.Show();
    	}
	public string TextBox
    	{
        	get { return tb1.Text; }

        	set { tb1.Text = value;}
        }
    	public void txt_changed(string str)
    	{
		tb1.Text=str;
       	
    	}

}
public class MyForm2 : System.Windows.Forms.Form
{
	
   	private System.Windows.Forms.TextBox tb2;
    	private System.Windows.Forms.Button btn;

    	public TextChangedDelegate tcd{get;set;} 

    	

    	public MyForm2()
    	{
        	Text="MyForm2";

        	tb2 = new System.Windows.Forms.TextBox();
        	tb2.Location = new System.Drawing.Point(100, 150);

        	btn = new System.Windows.Forms.Button();
        	btn.Text = "Ok";
        	btn.Location = new System.Drawing.Point(100, 200);
        	btn.Click += new System.EventHandler(btn_click);

        	Controls.Add(tb2);
        	Controls.Add(btn);
    	}
    	private void btn_click(System.Object o, System.EventArgs e)
    	{
                MyForm3 frm3 = new MyForm3();
       		frm3.TbText=tb2.Text;
		frm3.tcd+=new TextChangedDelegate(txt_changed); 
		frm3.Show();
        	
    	}
	public string TbText
    	{
		
		get { return tb2.Text; }

                set{ tb2.Text=value;}

	      	   
        }
	public void txt_changed(string str)
    	{
		tb2.Text=str;

 		if(tcd !=null)
		{
                   tcd(str);
		}
       	
    	}
}
public class MyForm3 : System.Windows.Forms.Form
{
	
   	private System.Windows.Forms.TextBox tb3;
    	private System.Windows.Forms.Button btn; 

	public TextChangedDelegate tcd{get;set;}

	public MyForm3()
    	{
        	Text="MyForm3";

        	tb3= new System.Windows.Forms.TextBox();
        	tb3.Location = new System.Drawing.Point(100, 150);

        	btn = new System.Windows.Forms.Button();
        	btn.Text = "Ok";
        	btn.Location = new System.Drawing.Point(100, 200);
        	btn.Click += new System.EventHandler(btn_click);

        	Controls.Add(tb3);
        	Controls.Add(btn);
    	}
	private void btn_click(System.Object o, System.EventArgs e)
        {
            	if(tcd !=null)
		{
			tcd(tb3.Text);
		}

        }
	public string TbText
    	{
		
		get { return tb3.Text; }

                set{ tb3.Text=value;}

	      	   
        }
	
	public void txt_changed(string str)
    	{
		tb3.Text=str;
       	
    	}
	

}

class Program
{
   	 public static void Main()
    	{
       		MyForm1 frm1=new MyForm1();
		System.Windows.Forms.Application.Run(frm1);
	
        }
}



	
	 
	

	    
        
	       
	
		