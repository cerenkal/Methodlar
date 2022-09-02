using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU 4:
            //Kullanıcının girdiği sayının faktöriyel sonucunu ekrana yazdıran program.
            FaktoriyelAl(SayiAl());
            Console.ReadLine();
        }
        static int SayiAl()
        {
            bool sayiMi = true;
            int sayi;
            do
            {
                Console.WriteLine("bir sayı girişi yapınız: ");
                sayiMi = Int32.TryParse(Console.ReadLine(), out sayi);

            } while (sayiMi != true );
            return sayi;
        }
        static void FaktoriyelAl(int sayi)
        {
            int faktoriyel=1;
            for (int i = sayi; i > 0; i--)
            {
                faktoriyel = faktoriyel*i;
            }
            Console.WriteLine($"{sayi}'nın faktöriyeli = {faktoriyel}");
        }
    }
}
