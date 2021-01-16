using System;

namespace Metodlar  
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Elma";
            double Fiyati = 15;
            string Aciklama = "Amasya Elmasi";

            string[] meyveler = new string[] { };

            Urun Urun1 = new Urun();
            Urun1.Adi = "Elma";
            Urun1.Fiyati = 15;
            Urun1.Aciklama = "Amasya Elmasi";

            Urun Urun2 = new Urun();
            Urun2.Adi = "Karpuz";
            Urun2.Fiyati = 80;
            Urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { Urun1, Urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("------------Metodlar------------");

            // instance
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);

            sepetManager.Ekle2("Armut", "Yeşil", 12,1);
            sepetManager.Ekle2("elma", "Yeşil elma", 12,1);
            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 12,1);
        }
    }
}


//tekrar tekrar kullanılabilirliği sağlayan yapılardır. Do not repeat yourself DRY 
//clean code 
//Best Practice