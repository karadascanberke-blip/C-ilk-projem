using System;
using System.Threading;

namespace GuzelBirOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            // Başlık kısmını camgöbeği (Cyan) renginde yazdırıyoruz
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║   Dijital Kahve Makinesine Hoş Geldiniz   ║");
            Console.WriteLine("╚═══════════════════════════════════════╝\n");
            Console.ResetColor();

            Console.WriteLine("Sıcak su ekleniyor ve çekirdekler öğütülüyor...");
            
            // Animasyonlu bir yükleme çubuğu (Loading bar) simülasyonu
            Console.Write("Hazırlanıyor: [");
            Console.ForegroundColor = ConsoleColor.Green;
            
            for (int i = 0; i < 20; i++)
            {
                Console.Write("■");
                Thread.Sleep(150); // Her kare için 150 milisaniye bekler
            }
            
            Console.ResetColor();
            Console.Write("]\n\n");

            // Sonuç mesajını sarı renkte gösteriyoruz
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("☕ Kahveniz hazır! Afiyet olsun.");
            Console.ResetColor();
            
            Console.ReadLine(); // Konsolun hemen kapanmaması için
        }
    }
}
