using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galeriv1
{
    class Galeri
    {
        public AracKayit aracKayit;
        public MusteriKayit musteriKayit;

        public Galeri()
        {
            Galeri.instace = this;
            aracKayit = new AracKayit();
            musteriKayit = new MusteriKayit();
        }


        //Static field

        private static Galeri instace;

        public static Galeri getInstance()
        {
            return Galeri.instace;
        }



    }
}
