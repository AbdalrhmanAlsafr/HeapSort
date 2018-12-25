using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My
{
    class Program
    {
     
        public static void yigin(int root, int node, int[] dizi)
        {
            bool bitis = false;
            int dugum, gecici;
            while ((root * 2 <= node) && (!bitis))
            {
                if (root * 2 == node)
                {
                    dugum = root * 2;
                }
                else if (dizi[root * 2] > dizi[root * 2 + 1])
                {
                    dugum = root * 2;
                }

                else
                    dugum = root * 2 + 1;
                if (dizi[root] < dizi[dugum])
                {
                    gecici = dizi[root];
                    dizi[root] = dizi[dugum];
                    dizi[dugum] = gecici;
                    root = dugum;
                }
                else
                {
                    bitis = true;

                }
            }

        }
      static void Main(string[] args)
        {
           
            int[] dizi = { 5, 3, 7, 9, 1, 4, 6, 2, 8 };
            int sayac;
            int gecici;
            for (sayac = ((dizi.Length / 2) - 1); sayac >= 0;
            sayac--)
            {
                yigin(sayac, dizi.Length, dizi);
            }
            for (int i = dizi.Length - 1; i >= 1; i--)
            {
                gecici = dizi[0];
                dizi[0] = dizi[i];
                dizi[i] = gecici;
                yigin(0, i - 1, dizi);
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            Console.ReadLine();
        }
       
        
    }
}
