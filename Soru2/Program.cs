using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU 2 :
            //Dışarıdan int olarak doğum yılı girilen kişinin yaşını hesaplayan program
            Hesapla(DogumYiliAl());

            Console.ReadLine();
        }
        static int DogumYiliAl()
        {
            Console.WriteLine("Doğum Yılınızı Giriniz: ");
            int year = Convert.ToInt32(Console.ReadLine());

            return year;
        }
        static void Hesapla(int year)
        {
            DateTime bugun = DateTime.Now;
            int age = bugun.Year - year ;
            Console.WriteLine($"Yaşınız= {age}");
        }
    }
}
