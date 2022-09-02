using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru8
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU 8 :
            //Bir kampüsteki öğrencilerin kilo ortalamalarını, cinsiyetlerine göre bulduran programı methodlar yazarak çözünüz.

            string[] cinsiyetler = new string[10];
            int i = 0;
            do
            {
                Console.WriteLine("Lütfen cinsiyetinizi giriniz: (erkek/kadın)");
                string cinsiyet = Console.ReadLine();
                cinsiyetler[i] = cinsiyet;
                i++;
            } while (i != 10);

            KiloHesaplama(cinsiyetler);
            Console.ReadLine();
        }
        static void KiloHesaplama(string[] cinsiyetler)
        {
            
            int kilo = 0;
            int kiloKadin = 0;
            int kiloErkek = 0;
            int kadinSayisi = 0;
            int erkekSayisi = 0;
            int kadinOrt = 0;
            int erkekOrt = 0;

            foreach (string item in cinsiyetler)
            {
                if (item == "erkek")
                {
                    Console.WriteLine("Lütfen kilonuzu giriniz: ");
                    kilo = int.Parse(Console.ReadLine());
                    kiloErkek += kilo;
                    erkekSayisi++;
                    erkekOrt = kiloErkek / erkekSayisi;
                }
                else if (item == "kadın")
                {
                    Console.WriteLine("Lütfen kilonuzu giriniz: ");
                    kilo = int.Parse(Console.ReadLine());
                    kiloKadin += kilo;
                    kadinSayisi++;
                    kadinOrt = kiloKadin / kadinSayisi;
                }
                
            }
            Console.WriteLine($"Kadın öğrencilerin ortalaması: {kadinOrt}");
            Console.WriteLine($"Erkek öğrencilerin ortalaması: {erkekOrt}");
            Console.ReadLine();

        }

    }

}
