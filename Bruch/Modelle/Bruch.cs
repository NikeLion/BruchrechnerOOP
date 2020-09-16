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

        public Bruch subtrahieren(Bruch bruch2)
        {
            int zaehl = 0;
            int nenn = 1;
            Bruch ergebnis = null;

            zaehl = this.Zaehler * bruch2.Nenner - bruch2.Zaehler * this.Nenner;
            nenn = this.Nenner * bruch2.Nenner;
            try
            {
                ergebnis = new Bruch(zaehl, nenn);
            }
            catch (Exception ex)
            {
                ergebnis = new Bruch(zaehl, 1);
            }

            return ergebnis;
        }

        public Bruch dividieren(Bruch bruch2)
        {
            int zaehl = 0;
            int nenn = 1;
            Bruch ergebnis = null;

            zaehl = this.Zaehler * bruch2.Nenner;
            nenn = bruch2.Zaehler * this.Nenner;
            try
            {
                ergebnis = new Bruch(zaehl, nenn);
            }
            catch (Exception ex)
            {
                ergebnis = new Bruch(zaehl, 1);
            }
            return ergebnis;
        }
        public Bruch multiplizieren(Bruch bruch2)
        {
            int zaehl = 0;
            int nenn = 1;
            Bruch ergebnis = null;

            zaehl = this.Zaehler * bruch2.Zaehler;
            nenn = this.Nenner * bruch2.Nenner;

            try
            {
                ergebnis = new Bruch(zaehl, nenn);
            }
            catch (Exception ex)
            {
                ergebnis = new Bruch(zaehl, 1);
            }

            return ergebnis;
        }
        public Bruch kuerzen()
        {
            int max = (this.Zaehler > this.Nenner) ? this.Zaehler: this.Nenner;


            for (int index = 0; index < max; index++)
            {

            }
        }
        #endregion
    }
}