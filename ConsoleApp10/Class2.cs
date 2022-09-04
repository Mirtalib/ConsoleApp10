namespace ConsoleApp10.Translate
{
    internal class Words
    {
        public string? Word { get; set; }
        public string? WordMeaning { get; set; }


        public Words()
        {
            Word = null;
            WordMeaning = null;
        }
        public Words(string word , string wordMeaning)
        {
            Word = word;
            WordMeaning = wordMeaning;
        }
    }
}
