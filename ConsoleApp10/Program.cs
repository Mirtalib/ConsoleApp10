using ConsoleApp10.Translate;
using ConsoleApp10.Article;
using ConsoleApp10.Client;
namespace ConsolApp10;

class Program
{
    static void Main() {


        Translate translate = new Translate();

        Words words = new Words("Word" , "Soz");
        translate.Words.Add(words);
        translate.Words.Add(new Words("Hello", "Salam"));
        translate.Words.Add(new Words("Boy", "Oglan"));
        translate.Words.Add(new Words("What", "Ne"));
        translate.Words.Add(new Words("List", "Siyahi"));
        translate.Words.Add(new Words("Family", "Aile"));
        translate.Words.Add(new Words("Men", "Kishi"));
        translate.Words.Add(new Words("Women", "Qadin"));
        translate.Words.Add(new Words("Prayer", "Dua"));
        translate.Words.Add(new Words("Invocation", "Cagirish"));
        translate.Words.Add(new Words("Magic", "Sehirli"));
        translate.Words.Add(new Words("Cat", "Pishik"));
        translate.Words.Add(new Words("Dog", "It"));
        translate.Words.Add(new Words("Rabbit", "Doshan"));
        translate.Words.Add(new Words("Lion", "Shir"));
        translate.Words.Add(new Words("Elephant", "Fil"));
        translate.Words.Add(new Words("Ball", "Top"));
        translate.Words.Add(new Words("Car", "Mashin"));
        translate.Words.Add(new Words("Apple", "Alma"));
        translate.Words.Add(new Words("Blue", "Goy"));
        translate.Words.Add(new Words("Red", "Qirmizi"));
        translate.Words.Add(new Words("Pink", "Penbe"));
        translate.Words.Add(new Words("Hat", "Papaq"));
        translate.Words.Add(new Words("Dress", "Paltar"));
        translate.Words.Add(new Words("T-Shirt", "Koynek"));
        translate.Words.Add(new Words("Star", "Ulduz"));
        translate.Words.Add(new Words("Home", "Ev"));
        translate.Words.Add(new Words("Sun", "Gunesh"));
        translate.Words.Add(new Words("Lemon", "Limon"));
        translate.Words.Add(new Words("Airplane", "Teyyare"));
        translate.Words.Add(new Words("Tree", "Agac"));



        ConsoleKeyInfo keyInfo;
        int i = 0;
        while (true) {
            Console.WriteLine("Sozu Daxil Edin:");
            string? word = Console.ReadLine();
            Console.Clear();
            for (i = 0; i < translate.Words.Count; i++) {
                
                if (word?.ToUpper() == translate.Words[i]?.Word?.ToUpper()) {
                    Console.WriteLine($"Tercumesi->{translate.Words[i].WordMeaning}\n");
                    break;
                }
            }

            if (i == translate.Words.Count)
            {
                Console.WriteLine("Soz Tapilmadi");
            }

            Console.WriteLine("Davam Etmek Ucun Enter \nCixmaq Ucun Tab-a Basin");
            keyInfo = Console.ReadKey();


            if (keyInfo.Key is ConsoleKey.Enter) {
                Console.Clear();
            }
            else if(keyInfo.Key is ConsoleKey.Tab)
            {
                Console.Clear();
                break;
            }
            else
            {
                Console.Clear();
            }
        }


        /// 2
        Article article = new Article("Apple",12345543,1000);
        Article article2 = new Article("Samsung", 7890012, 900);

        Console.WriteLine(article == article2);
        Console.WriteLine(article != article2);

        Console.WriteLine(article + article2);
        Console.WriteLine(article * article2);
        Console.WriteLine(article - article2);
        Console.WriteLine(article / article2);

        Console.WriteLine(article++);

        Console.WriteLine(--article);


        // 3


        Client client1 = new Client("9856467", "Mirtalib", "Mireli Seyidov 31/32", "050598345", "12323", 22);
        Client client2 = new Client("4534265", "Eli", "Semed Vurgun 12", "123456543234", "9099", 100);


        Console.WriteLine(client1 == client2);
        Console.WriteLine(client2 != client1);

        Console.WriteLine(client2 + client1);
        Console.WriteLine(client2 - client1);
        Console.WriteLine(client2 / client1);
        Console.WriteLine(client2 * client1);


        Console.WriteLine(client1);

    }
}