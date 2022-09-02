using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru6
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU 6 : Kullanının girdiği, 50'şer adet A,B,C değeri Y = (A+B) / C işlemi hesaplanıyor. 
            //Pozitif Y'lerin aritmetik ortalamasını, 30'dan büyük 50'den küçük Y'lerin sayısını bulduran programı methodlarını yazarak çözünüz.
            //Bu soruyu metotlar ile çözünüz.Normal çözümünü zaten sınıfta yaptık sizlerden metotlar ile çözmenizi bekliyorum.

            int sayi1, sayi2, sayi3;
            int[] sayilarA = new int[50];
            int[] sayilarB = new int[50];
            int[] sayilarC = new int[50];

            int i = 0;
            do
            {
                Console.WriteLine("A için bir sayı girişi yapınız: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                sayilarA[i] = sayi1;
                Console.WriteLine("B için bir sayı girişi yapınız: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                sayilarB[i] = sayi2;
                Console.WriteLine("C için bir sayı girişi yapınız: ");
                sayi3 = Convert.ToInt32(Console.ReadLine());
                sayilarC[i] = sayi3;
                i++;

            } while (sayi3 != 0 && i != 50);

            YHesaplama(sayilarA, sayilarB, sayilarC);



            Console.ReadLine();
        }

        static void YHesaplama(int[] A, int[] B, int[] C)
        {
            int Y = 0;
            int sayac = 0;
            int adet = 0;
            int toplamY = 0;
            double ortY = 0;
            foreach (int item in A)
            {
                foreach (var item1 in B)
                {
                    foreach (var item2 in C)
                    {
                        Y = ((item + item1) / item2);
                        if (Y > 0)
                        {
                            sayac++;
                            toplamY = toplamY + Y;
                            ortY = toplamY / sayac;

                            if (Y > 30 && Y < 50)
                            {
                                adet = adet + 1;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"30 dan büyük 50 den küçük Y değerleri {adet}' dir");
            Console.WriteLine($"Pozitif Y değerlerinin aritmetik ortalaması = {ortY}");
        }

    }
}
