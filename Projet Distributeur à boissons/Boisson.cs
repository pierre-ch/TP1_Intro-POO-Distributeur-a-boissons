using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Distributeur_à_boissons
{
    class Boisson
    {
        private string intitule;
        private string description;
        private double prix = 0.5;
        private int qt = 10;
        private int qtsucre;
        private bool chg_qtsucre;
        private string etat;
                                                                        
        public Boisson(string unIntitule, string uneDescription, double unPrix, int uneQuantite, int uneQuantiteDeSucre, bool unChangementQuantiteDeSucre, string unEtat)
        {
            this.intitule = unIntitule;
            this.description = uneDescription;
            this.prix = unPrix;
            this.qt = uneQuantite;
            this.qtsucre = uneQuantiteDeSucre;
            this.chg_qtsucre = unChangementQuantiteDeSucre;
            this.etat = unEtat;
        }

        public string getIntitule()
        {
            return intitule;
        }

        public string getDescription()
        {
            return description;
        }

        public double getPrix()
        {
            return prix;
        }
        public int getStockDisponible()
        {
            return qt;
        }

        public void setQuantite(int uneQuantite)
        {
            qt = uneQuantite;
        }
    }
}
