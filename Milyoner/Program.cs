using System;

class Program
{
    static void Main()
    {
        int dogruCevaplar = 0;

        // 1. Soru
        Console.WriteLine("1 -> Bozkırın tezenesi lakaplı rahmetli halk ozanı kimdir?");
        Console.WriteLine("a) Neset Ertas   b) Kıvırcık Ali");
        Console.Write("Cevabınızı giriniz (A veya B): ");
        string cevap1 = Console.ReadLine().ToLower(); // Küçük harfe dönüştür

        if (cevap1 == "a")
        {
            Console.WriteLine("Tebrikler! Doğru cevap.");
            dogruCevaplar++;
        }
        else if (cevap1 == "b")
        {
            Console.WriteLine("Maalesef yanlış cevap.");
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen sadece A veya B giriniz.");
        }

        // 2. Soru
        Console.WriteLine("\n2 -> Gülü ile meşhur olan ilimiz hangisidir?");
        Console.WriteLine("a) Isparta   b) Giresun");
        Console.Write("Cevabınızı giriniz (A veya B): ");
        string cevap2 = Console.ReadLine().ToLower(); // Küçük harfe dönüştür

        if (cevap2 == "a")
        {
            Console.WriteLine("Tebrikler! Doğru cevap.");
            dogruCevaplar++;
        }
        else if (cevap2 == "b")
        {
            Console.WriteLine("Maalesef yanlış cevap.");
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen sadece A veya B giriniz.");
        }

        // 3. Soru sadece birinci veya ikinci soruya doğru cevap verilmişse gösterilir
        if (dogruCevaplar == 1)
        {
            Console.WriteLine("\n3 -> İstanbul'un plakası kaçtır?");
            Console.WriteLine("a) 34   b) 07");
            Console.Write("Cevabınızı giriniz (A veya B): ");
            string cevap3 = Console.ReadLine().ToLower(); // Küçük harfe dönüştür

            if (cevap3 == "a")
            {
                Console.WriteLine("Tebrikler! Doğru cevap.");
                dogruCevaplar++;
            }
            else if (cevap3 == "b")
            {
                Console.WriteLine("Maalesef yanlış cevap.");
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen sadece A veya B giriniz.");
            }
        }

        // Sonuç
        if (dogruCevaplar == 2)
        {
            Console.WriteLine("\nTebrikler! Büyük ödülü kazandınız!");
        }
        else
        {
            Console.WriteLine("\nMaalesef büyük ödülü kazanamadınız.");
        }
    }
}
