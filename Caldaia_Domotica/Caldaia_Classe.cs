using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caldaia_Domotica
{
    internal class Caldaia_Classe
    {
        private bool stato;
        private string modalità;
        private int temperatura;
        private string produttore;
        private string modello;
        private string nrserie;
        private string datainst;

        //STATO
        public void on()
        {
            setStato(true);
        }
        public void off()
        {
            setStato(false);
        }
        private void setStato(bool newStato)
        {
            stato = newStato;
        }
        public bool getStato()
        {
            return stato;
        }
        public bool invert()
        {
            setStato(!stato);
            return stato;
        }

        //MODALITA'
        public void setMod(string newMod)
        {
            modalità = newMod;
        }
        public string getMod()
        {
            return modalità;
        }

        //TEMPERATURA
        public void setTemp(int newTemp)
        {
            temperatura = newTemp;
        }
        public int getTemp()
        {
            return temperatura;
        }

        //PRODUTTORE
        public string setProduttore(string newProduttore)
        {
            produttore = newProduttore;
            return produttore;
        }

        //MODELLO
        public string setModello(string newModello)
        {
            modello = newModello;
            return modello;
        }

        //NUMERO DI SERIE
        public string setNrserie(string newNrserie)
        {
            nrserie = newNrserie;
            return nrserie;
        }

        //NUMERO DI SERIE
        public string setDatainst(string newDatainst)
        {
            datainst = newDatainst;
            return datainst;
        }
    }
}
