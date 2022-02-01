using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Boisson
{
    class Program
    {

        static void Main(string[] args)
        {
            char reponse;
            bool recommencer;
            int qteSucre;

            Boisson cafe_court = new Boisson("Café court", "Café court expresso", 0.50, 2, 1, true, "Chaude");
            Boisson cafe_long = new Boisson("Café long", "Café long expresso", 0.50, 2, 1, true, "Chaude");
            Boisson cappuccino = new Boisson("Cappuccino", "Café avec une mousse de lait contueuse", 0.50, 10, 2, true, "Chaude");
            Boisson the_nature = new Boisson("Thé nature", "Thé noir Ceylan", 0.70, 10, 1, true, "Chaude");
            Boisson the_menthe = new Boisson("Thé menthe", "Thé vert aromatisé à la menthe", 0.75, 10, 2, true, "Chaude");
            Boisson potage_tomage = new Boisson("Potage tomate", "Potage chaud à base de concentré de tomages", 0.40, 10, 0, false, "Chaude");
            Boisson orange = new Boisson("Orange", "Boisson à base de concentré d'oranges", 0.55, 10, 0, false, "Froide");
            Boisson boissonChoisi = new Boisson("?", "?", 0, 0, 0, true, "?");


            do
            {
                try
                {
                    Console.WriteLine("Choississez une boisson: " +
                        "\n 1: {0} " +
                        "\n 2: {1} " +
                        "\n 3: {2} " +
                        "\n 4: {3} " +
                        "\n 5: {4} " +
                        "\n 6: {5} " +
                        "\n 7: {6} " +
                        "\n 8: Quitter " +
                        "\n", cafe_court.getIntitule(), cafe_long.getIntitule(), cappuccino.getIntitule(), the_nature.getIntitule(), the_menthe.getIntitule(), potage_tomage.getIntitule(), orange.getIntitule());
                    reponse = char.Parse(Console.ReadLine());
                    recommencer = false;
                    switch(reponse)
                    {
                        case '1':
                            boissonChoisi = cafe_court;
                            break;
                        case '2':
                            boissonChoisi = cafe_long;
                            break;
                        case '3':
                            boissonChoisi = cappuccino;
                            break;
                        case '4':
                            boissonChoisi = the_nature;
                            break;
                        case '5':
                            boissonChoisi = the_menthe;
                            break;
                        case '6':
                            boissonChoisi = potage_tomage;
                            break;
                        case '7':
                            boissonChoisi = orange;
                            break;
                        case '8':
                            Console.WriteLine("A bientôt !");
                            recommencer = false;
                            break;
                    }

                    Console.WriteLine("----------------" + boissonChoisi.getQuantiteBoisson());

                    if (boissonChoisi.getQuantiteBoisson() == 1)
                    {
                        boissonChoisi.setIntitule(boissonChoisi.getIntitule() + " - INDISPONIBLE");
                    }

                    if (boissonChoisi.stockDisponible())
                    {
                        
                        recommencer = true;
                        Console.WriteLine(boissonChoisi.getDescription());
                        Console.WriteLine(boissonChoisi.getEtatBoisson());
                        if (boissonChoisi.getSucre() == true)
                        {
                            Console.WriteLine("Il y a actuellement {0} sucre(s) dans votre boisson, voulez-vous modifier cette quantitée ? o/n", boissonChoisi.getQuantiteSucre());
                            reponse = char.Parse(Console.ReadLine());
                            if (reponse == 'o')
                            {
                                do
                                {
                                    Console.WriteLine("Indiquez la quantité de sucre que vous souhaitez (min 0 - max 9)");
                                    qteSucre = int.Parse(Console.ReadLine());
                                    boissonChoisi.setQuantiteSucre(qteSucre);
                                } while (qteSucre < 0 || qteSucre > 9);
                                Console.WriteLine("Nouvelle quantité de sucre: {0}", boissonChoisi.getQuantiteSucre());
                                Console.WriteLine("Votre boisson est en cours de préparation, vous devrez payer {0} euros \n", boissonChoisi.getPrix());
                                boissonChoisi.setQuantiteBoisson(boissonChoisi.getQuantiteBoisson() - 1);

                            } else
                            {
                                Console.WriteLine("Nous avons laissé la quantité de sucre par défaut, à savoir {0}", boissonChoisi.getQuantiteSucre());
                                Console.WriteLine("Votre boisson est en cours de préparation, vous devrez payer {0} euros \n", boissonChoisi.getPrix());
                                boissonChoisi.setQuantiteBoisson(boissonChoisi.getQuantiteBoisson() - 1);
                            }
                        } else
                        {
                            Console.WriteLine("Votre boisson est en cours de préparation, vous devrez payer {0} euros \n", boissonChoisi.getPrix());
                            boissonChoisi.setQuantiteBoisson(boissonChoisi.getQuantiteBoisson() - 1);
                        }
                        
                    }
                    else if (!boissonChoisi.stockDisponible())
                    {
                        recommencer = false;
                        Console.WriteLine("Indisponible");
                    }
                }
                catch (Exception error)
                {
                    Console.WriteLine("Erreur de saisie \n");
                    recommencer = true;
                }
            } while (recommencer);
             


            
            Console.ReadKey(true);
        }
    }
}
