using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();

            Console.Write("TC Kimlik Numaranızı giriniz:"); string TCNO = Console.ReadLine();
            if (ulong.TryParse(TCNO, out ulong tcno))
            {
                personel.TcKimlikNo = tcno;
                Console.WriteLine("TC KİMLİK NO=" + personel.TcKimlikNo);
            }
            else
            {
                Console.WriteLine($"Geçersiz bir sayı girdiniz: {TCNO}");
            }
        }
    }
}
