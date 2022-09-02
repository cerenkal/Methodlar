using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru7
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU 7 :
            //Klavyeden girilen 25 adet sayı içerisinden negatif olanların toplamını, çift sayıların çarpımını
            //7'ye eşit olanların adetini bulup ekrana yazdıran programı methodlarını yazarak çözünüz.
            //Bu soruyu metotlar ile çözünüz.Normal çözümünü zaten sınıfta yaptık sizlerden metotlar ile çözmenizi bekliyorum.

            int sayi;
            int i = 0;
            int[] sayilar = new int[25];
            do
            {
                Console.WriteLine("Sayı Girişi Yapınız: ");
                sayi = Convert.ToInt32(Console.ReadLine().Trim());
                sayilar[i] = sayi;
                i++;
            } while (i!=25);

            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }

            NegatifTopla(sayilar);
            CiftCarp(sayilar);
            YediyeEsit(sayilar);

            Console.ReadLine();
           
        }
        static void NegatifTopla(int[] sayilar)
        {

            int toplam = 0;
            foreach (int item in sayilar)
            {
                if (item < 0)
                {
                    toplam = toplam + item;
                }
            }
            
            Console.WriteLine($"negatiflerin toplamı = {toplam}");

        }
        static void CiftCarp(int[] sayilar)
        {

            int carpım = 1;
            foreach (int item in sayilar)
            {
                if (item % 2 == 0 && item > 0)
                {
                    carpım = carpım * item;
                }
            }
            
            Console.WriteLine($"çift sayıların çarpımı = {carpım}");

        }
        static void YediyeEsit(int[] sayilar)
        {
            int adet = 0;
            foreach (int item in sayilar)
            {
                if (item == 7 && item>0)
                {
                    adet++;
                }
            }
            
            Console.WriteLine($"girilen sayılardan 7 ye eşit olanların sayısı = {adet}");

        }
    }
}
