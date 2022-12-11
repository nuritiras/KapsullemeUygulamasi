using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeUygulamasi
{
    public class Personel
    {
        private ulong tckimlikno;

        public ulong TcKimlikNo
        {
            get
            {
                return tckimlikno / 1000000;
            }

            set
            {
                if (value >= 10000000000 && value < 100000000000)
                {
                    tckimlikno = value;
                }
                else
                {
                    Console.WriteLine("Girdiğiniz TC KİMLİK NO 11 karekter değidir.");
                }
            }
        }
    }
}