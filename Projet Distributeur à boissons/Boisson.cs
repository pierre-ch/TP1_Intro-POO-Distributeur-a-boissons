using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Distributeur_à_boissons
{
    class Boisson
    {
        private string intitulé;
        private string description;
        private double prix;
        private int qt;
        private int qtsucre;
        private bool chg_qtsucre;
        private string etat;

        public Boisson(string unIntitulé, string uneDescription, double unPrix, int uneQuantite, int uneQuantiteDeSucre, bool unChangementQuantiteDeSucre, string unEtat)
        {
            this.intitulé = unIntitulé;
            this.description = uneDescription;
            this.prix = unPrix;
            this.qt = uneQuantite;
            this.qtsucre = uneQuantiteDeSucre;
            this.chg_qtsucre = unChangementQuantiteDeSucre;
            this.etat = unEtat;
        }



    }
}
