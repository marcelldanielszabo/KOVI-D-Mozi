﻿using System;
using System.Collections.Generic;
using System.Text;
using static KOVI_D_Mozi.Dátum;

namespace KOVI_D_Mozi
{
    class Vetítés
    {
        private int ID;
        private int Film_ID;
        private int Szek_ID;
        private Dátum Datum;

        public Vetítés(string sor,Dátum date)
        {
            string[] adat = sor.Split(';');
        }
        ~Vetítés() { }

        public int _ID { get => ID; set => ID = value; }
        public int _Film_ID { get => Film_ID; set => Film_ID = value; }
        public int _Szek_ID { get => Szek_ID; set => Szek_ID = value; }
        internal Dátum _Datum { get => Datum; set => Datum = value; }
    }
}
