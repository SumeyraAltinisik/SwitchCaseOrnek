
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ehliyet belgenizin sınıfını yazınız.");
            char sinif = Convert.ToChar(Console.ReadLine());
            switch (sinif)
            {
                case 'a':
                    Console.WriteLine("Tüm motorlar");
                    break;
                case 'b':
                    Console.WriteLine("Otomobil,kamyonet");
                    break;
                case 'c':
                    Console.WriteLine("Kamyon, çekici");
                    break;
                case 'd':
                    Console.WriteLine("Minibüs, otobüs");
                    break;
                case 'f':
                    Console.WriteLine("Traktör");
                    break;
                case 'g':
                    Console.WriteLine("İş makinesi");
                    break;
                case 'm':
                    Console.WriteLine("Motorlu bisiklet");
                    break;
                default:
                    Console.WriteLine("Böyle bir sınıf tanımlanmadı");
                    break;
            }
            Console.ReadKey();
        }
    }
}
