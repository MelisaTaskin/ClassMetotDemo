using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {

          Console.WriteLine("Müşteri eklendi " + " : " + musteri.AdiSoyadi);
         
            Console.WriteLine("Kart Türü"+ " : " + musteri.KartTuru);
            Console.WriteLine("Bakiye" + " : " + musteri.Bakiye);

             
            

            }

        public void Ekle2(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi" + " : " + musteri.AdiSoyadi);
            Console.WriteLine("Silinme Nedeni" + " : " + musteri.Neden);

        }



    }




    }

