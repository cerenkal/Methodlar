using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORU 3 :
            // Sizin oluşturduğunuz bir sayısal dizini ortalamasını bulan metodu yazınız.

            int[] numbers = {1,5,54,87,60,101};
            OrtalamaBul(numbers);
            Console.ReadLine();
        }
        static void OrtalamaBul(int[] numbers)
        {
            double toplam = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                toplam = toplam + numbers[i];
            }
            double ortalama = toplam / (numbers.Length);
            
            Console.WriteLine($"dizinin elemanlarının ortalaması = {Math.Round(ortalama)}");
        }
    }
}
