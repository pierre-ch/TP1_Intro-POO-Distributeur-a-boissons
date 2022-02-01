using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Boisson
{
    class Boisson
    {
        private string intituleBoisson;
        private string descriptionBoisson;
        private double prixBoisson = 0.5;
        private int quantiteBoisson = 10;
        private int quantiteSucre;
        private bool sucre;
        private string etatBoisson;

        public Boisson(string unIntituleBoisson, string uneDescriptionBoisson, double unPrixBoisson, int uneQuantiteBoisson, int uneQuantiteSucre, bool sucre, string unEtatBoisson)
        {
            this.intituleBoisson = unIntituleBoisson;
            this.descriptionBoisson = uneDescriptionBoisson;
            this.prixBoisson = unPrixBoisson;
            this.quantiteBoisson = uneQuantiteBoisson;
            this.quantiteSucre = uneQuantiteSucre;
            this.sucre = sucre;
            this.etatBoisson = unEtatBoisson;
        }

        public string getIntitule()
        {
            return this.intituleBoisson;
        }
        public void setIntitule(string leNom)
        {
            this.intituleBoisson = leNom;
        }

        public string getDescription()
        {
            return this.descriptionBoisson;
        }

        public double getPrix()
        {
            return this.prixBoisson;
        }

        public int getQuantiteBoisson()
        {
            return this.quantiteBoisson;
        }
        public void setQuantiteBoisson(int laQuantite)
        {
            this.quantiteBoisson = laQuantite;
            return;
        }

        

        public string getEtatBoisson()
        {
            return this.etatBoisson;
        }

        public bool getSucre()
        {
            return this.sucre;
        }


        public int getQuantiteSucre()
        {
            return this.quantiteSucre;
        }

        public void setQuantiteSucre(int laQuantite)
        {
            this.quantiteSucre = laQuantite;
            return;
        }

        public bool stockDisponible()
        {
            bool vretour;
            if (quantiteBoisson > 0)
            {
                vretour = true;
            } else
            {
                vretour = false;
            }
            return vretour;
        }
    }
}
