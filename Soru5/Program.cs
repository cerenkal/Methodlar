using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru5
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU 5 :
            //Kullanıcıya programa hoşgeldiniz yazan bir metot.
            //Kullanıcıdan yapmak istediği işlemi soran ve bir cevap alan metot.
            //Toplama / Çıkarma / Çarpma / Bölme işlemleri için bir metot
            //Tekrar yapmak ister misiniz diye soran bir metot.
            //Bunların birleşimi ile hesap makinesi kodu.
            Karsılama();
            Islem(85,5,IslemSecimi());
            Tekrarlama();

            Console.ReadLine();
        }
        static void Karsılama()
        {
            Console.WriteLine("**********HOŞGELDİNİZ**********");
        }
        static void Tekrarlama()
        {
            string evetMi;

            Console.WriteLine("TEKRAR ETMEK İSTER MİSİNİZ? evet/hayır");
            evetMi = (Console.ReadLine().Trim());
            if (evetMi == "E" || evetMi == "e")
            {
                Islem(85, 5, IslemSecimi());
                Tekrarlama();
            }
            else if (evetMi=="H"||evetMi=="h")
            {
                Console.WriteLine("**********HOŞÇAKALIN**********");
            }

        }
        static char IslemSecimi()
        {
            Console.WriteLine("Yapmak istediğiniz işlem nedir? T/F/Ç/B: ");
            char islem = Convert.ToChar(Console.ReadLine().Trim());
            return islem;
        }
        static void Islem(int a,int b,char islem)
        {
            if (islem == 'T' || islem == 't')
            {
                Toplama(a,b);
            }
            if (islem == 'F' || islem == 'f')
            {
                Fark(a, b);
            }
            if (islem == 'Ç' || islem == 'ç')
            {
                Carpma(a, b);
            }
            if (islem == 'B' || islem == 'b')
            {
                Bolme(a, b);
            }
        }
        static void Toplama(int a,int b)
        {
            int sonuc = a + b;
            Console.WriteLine($"İki Sayının Toplamı = {sonuc}'dır.");
        }
        static void Fark(int a, int b)
        {
            int sonuc = a - b;
            Console.WriteLine($"İki Sayının Farkı = {sonuc}'dır.");
        }
        static void Carpma(int a, int b)
        {
            int sonuc = a * b;
            Console.WriteLine($"İki Sayının Çarpımı = {sonuc}'dır.");
        }
        static void Bolme(int a, int b)
        {
            int sonuc = a / b;
            Console.WriteLine($"İki Sayının Bölümü = {sonuc}'dır.");
        }
    }
}
