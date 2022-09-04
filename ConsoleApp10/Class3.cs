namespace ConsoleApp10.Article
{
    internal class Article
    {

        string ProductName { get; set; }
        int ProductCode { get; set; }
        int Price { get; set; }



        public Article(string productName , int productCode , int price)
        {
            ProductName = productName;
            ProductCode = productCode;
            Price = price;
        }


        public static int operator +(Article s1 , Article s2)
        {
            return s1.Price + s2.Price;    
        }

        public static int operator -(Article s1, Article s2)
        {
            return s1.Price - s2.Price;
        }
        public static int operator *(Article s1, Article s2)
        {
            return s1.Price * s2.Price;
        }
        public static int operator /(Article s1, Article s2)
        {
            return s1.Price / s2.Price;
        }


        public static bool operator ==(Article s1, Article s2)
        {
            return s1.ProductName == s2.ProductName && s1.ProductCode == s2.ProductCode && s1.Price == s2.Price;
        }
        
        public static bool operator !=(Article s1, Article s2)
        {
            return s1.ProductName != s2.ProductName && s1.ProductCode != s2.ProductCode && s1.Price != s2.Price;
        }

        public static Article operator ++(Article a1)
        {
            a1.Price++;
            return a1;
        }

        public static Article operator --(Article a1)
        {
            a1.Price--;
            return a1;
        }

        public override string ToString() 
            =>$"product name=>{ProductName}\nProduct code=>{ProductCode}\nProduct price=>{Price}";

        
    }
}
