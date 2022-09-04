using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Client
{
    internal class Client
    {
        string Clientcode { get; set; }
        string Fullname { get; set; }
        string Adress { get; set; }
        string Telephone { get; set; }
        string NumberOrders { get; set; }
        int TotalAmaount { get; set; }
        public Client(string clientcode, string fullname, string adress, string telephone, string numberorders, int totalamount)
        {
            Clientcode = clientcode;
            Fullname = fullname;
            Adress = adress;
            Telephone = telephone;
            NumberOrders = numberorders;
            TotalAmaount = totalamount;
        }

        public static int operator +(Client s1, Client s2)
        {
           return s1.TotalAmaount + s2.TotalAmaount;
        }

        public static int operator -(Client s1, Client s2)
        {
            return s1.TotalAmaount - s2.TotalAmaount;
        }
        public static int operator *(Client s1, Client s2)
        {
            return s1.TotalAmaount * s2.TotalAmaount;
        }
        public static int operator /(Client s1, Client s2)
        {
            return s1.TotalAmaount / s2.TotalAmaount;
        }

        public static bool operator !=(Client s1, Client s2)
        {
            return s1.Fullname != s2.Fullname 
                && s1.Adress != s2.Adress 
                && s1.Clientcode != s2.Clientcode 
                && s1.NumberOrders != s2.NumberOrders
                && s1.Telephone != s2.Telephone
                && s1.TotalAmaount != s2.TotalAmaount;
        }


        public static bool operator ==(Client s1, Client s2)
        {
            return s1.Fullname == s2.Fullname
                && s1.Adress == s2.Adress
                && s1.Clientcode == s2.Clientcode
                && s1.NumberOrders == s2.NumberOrders
                && s1.Telephone == s2.Telephone
                && s1.TotalAmaount == s2.TotalAmaount;
        }

        public override string ToString()
        {
        
            return($"Client Code=>{Clientcode}\n" +
                $"Full Name=>{Fullname}\n" +
                $"Adress=>{Adress}\n" +
                $"Telephone=>{Telephone}\n" +
                $"Number of orders=>{NumberOrders}\n" +
                $"Total Amount=>{TotalAmaount}\n");
        }
    }
}
