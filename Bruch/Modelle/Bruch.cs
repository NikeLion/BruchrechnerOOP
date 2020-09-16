using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bruch
{
    class Bruch
    {
        //Attribute
        private int _zaehler;
        private int _nenner;


        #region Konstruktoren
        public Bruch(int zaehler, int nenner)
        {
            this.Zaehler = zaehler;
            this.Nenner = nenner;
        }

        public Bruch()
        {
            this.Zaehler = 1;
            this.Nenner = 1;
        }

        #endregion

        #region Selektoren
        public int Zaehler { get => _zaehler; set => _zaehler = value; }
        public int Nenner { get => _nenner; set => _nenner = value; }
        #endregion

        #region Funktionen
        public void addieren(Bruch bruch)
        {
            Bruch ergebnis = new Bruch();
            ergebnis.Zaehler = this.Nenner * bruch.Zaehler + bruch.Nenner * this.Zaehler;
            ergebnis.Nenner= this.Nenner * bruch.Nenner;
             
        }

        public void subtrahieren(Bruch bruch)
        {

        }

        public void dividieren(Bruch bruch)
        {

        }
        public void multiplizieren(Bruch bruch)
        {

        }
        public void kuerzen()
        {
            int max = (this.Zaehler > this.Nenner) ? this.Zaehler: this.Nenner;


            for (int index = 0; index < max; index++)
            {

            }
        }
        #endregion
    }
}