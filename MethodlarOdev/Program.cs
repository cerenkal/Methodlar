using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodlarOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU 1 :
            // Kullanıcının adı ve soyadını alıp ekrana Ad Soyad sisteme hoşgeldiniz yazan metot.
            KullaniciBilgiAl();

            Console.ReadLine();

        }
        static void KullaniciBilgiAl()
        {
            Console.WriteLine("adınızı giriniz: ");
            string name = Console.ReadLine();

            Console.WriteLine("soyadınızı giriniz: ");
            string surname = (Console.ReadLine());

            string fullName = name +" "+ surname;
            
            Console.WriteLine($"{fullName.ToUpper()} sisteme Hoş Geldiniz...");
        }
    }
}
