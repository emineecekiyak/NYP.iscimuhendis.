﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyp.Odev._24._10
{
    internal class Personel
    {
        public Personel(string gAd, string gAdres, int gYas, int gMesai, string gUnvan)
        {
            this.Ad = gAd;
            this.Adres = gAdres;
            this.Yas = gYas;
            this.Mesai = gMesai;
            this.Unvan = gUnvan;


        }
        string ad;
        public string Ad { get => ad; set => ad = value; }

        string adres;
        public string Adres { get => adres; set => adres = value; }

        int yas;
        public int Yas { get => yas; set => yas = value; }

        string unvan;
        public string Unvan { get => unvan; set => unvan = value; }

        int mesai;
        public int Mesai { get => mesai; set => mesai = value; }

        public int ucretHesapla()
        {
            return this.Mesai * 100;
        }
        public void ucretHesapla(int ekUcret)
        {
            MessageBox.Show((this.Mesai * 100 + ekUcret).ToString());
        }

    }
}
