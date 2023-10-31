using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DikdortgenNesneOlusturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen(13,40);
            Console.WriteLine("Dikdörtgen Alanı="+ dikdortgen.alanHesapla());
            Console.WriteLine("Dikdörtge Çevresi=" + dikdortgen.cevreHesapla());
        }
    }
    class Dikdortgen
    {
        private int kisaKenar, uzunKenar;
        public Dikdortgen(int kisaKenar, int uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }
        public int alanHesapla()
        {
            return kisaKenar * uzunKenar;
        }
        public int cevreHesapla()
        {
            return 2 * (kisaKenar + uzunKenar);
        }
    }
}
