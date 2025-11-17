using System;
using System.IO;

namespace streams_serializable
{


    [Serializable]

    public class product
    {
        private int pid;
        private String pname;


        private double price;

        public int Pid
        {
            get
            {
                return pid;
            }
            set
            {
                pid = value;
            }

        }
        public String Pname
        {
            get
            {
                return pname;
            }
            set
            {
                pname = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }

    public class Serialization_Deserialization
    {
        public static void Main()
        {
            product p = new product() { Pid = 1001, Pname = "lenovo", Price = 65000.50 };
            System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf;

            System.IO.FileStream fs = new FileStream("product.txt", FileMode.Create, FileAccess.Write);

            bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            bf.Serialize(fs, p);
            fs.Close();

            fs = new FileStream("product.txt", FileMode.Open, FileAccess.Read);
            bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            object obj = bf.Deserialize(fs);
            product temp = (product)obj;
            System.Console.WriteLine("{0}{1}{2}", temp.Pid, temp.Pname, temp.Price);
            fs.Close();

        }
    }



}

