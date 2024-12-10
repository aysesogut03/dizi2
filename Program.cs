using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            
            int tekadet = 0;
            int ciftadet = 0;
            int teksayilartoplamı = 0;
            int ciftsayilartoplamı = 0;
            int kullanıcıdeger;

            for(int i=0; i <sayilar.Length ; i++)
            {
                Console.Write((i)+" . index değerini giriniz: ");
                kullanıcıdeger=Convert.ToInt32(Console.ReadLine());
                sayilar[i] = kullanıcıdeger;
            }

            for(int j=0;j<sayilar.Length;j++)
            {
                if (sayilar[j]%2==0)
                {
                    ciftadet++;
                    ciftsayilartoplamı += sayilar[j];
                }

                else
                {
                    tekadet++;
                    teksayilartoplamı += sayilar[j];
                }
            }
            if(ciftsayilartoplamı>teksayilartoplamı)
            {
                Console.WriteLine("Çift sayılar toplamı tek sayılar toplamından büyüktür.");
            }
            else
            {
                Console.WriteLine("Tek sayıların toplamı çift sayılarıntoplamından büyüktür.");
            }

            Console.WriteLine("tek sayılar toplamı:" + teksayilartoplamı);
            Console.WriteLine("çift sayılar toplamı:" + ciftsayilartoplamı);
            Console.WriteLine("tek adet:" + tekadet);
            Console.WriteLine("çift adet:" + ciftadet);
            Console.ReadLine();
        }
    }
}
