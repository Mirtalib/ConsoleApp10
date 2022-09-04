namespace ConsoleApp10.Translate
{
    internal class Translate
    {
        public List<Words> Words { get; set; } = new();



        public Words this[int index]
        {
            get
            {
                return Words[index];    
            }

            set
            {
                Words![index] = value;
            }
        }
    }
}
