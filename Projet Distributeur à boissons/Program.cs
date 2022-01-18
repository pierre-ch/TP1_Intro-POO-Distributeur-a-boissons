using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Distributeur_à_boissons
{
    class Program
    {
        static void Main(string[] args)
        {
            Boisson cafe = new Boisson("café", "origine Pérou - type expresso - corsé", 0.5, 10, 1, false, "chaude");
            bool erreur1 = false;
            do
            {
                erreur1 = false;
                try
                {
                    string rep, recafe;
                    bool encore = false;
                    Console.WriteLine("Bonjour voulez-vous un café ? (OUI/NON)");
                    rep = Console.ReadLine().ToUpper();

                    if (rep.Equals("OUI"))
                    {
                        Console.WriteLine("b1");
                        do
                        {
                            try
                            {
                                encore = false;

                                if (cafe.getStockDisponible() > 0)
                                {
                                    Console.WriteLine("Votre choix : " + cafe.getIntitule() + " " + cafe.getDescription());
                                    Console.WriteLine("Préparation en cours...");
                                    Console.WriteLine("Vous devez " + cafe.getPrix() + " euros");
                                    Console.WriteLine("Boisson prête !");
                                    cafe.setQuantite((cafe.getStockDisponible() - 1));
                                    Console.WriteLine("Souhaitez-vous un autre café ? (OUI/NON)");
                                    recafe = Console.ReadLine().ToUpper();
                                    if (recafe.Equals("OUI"))
                                    {
                                        encore = true;
                                    }
                                    else
                                    {
                                        encore = false;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Désolé, mais il n'y a plus de café.");
                                }
                            }
                            catch (Exception erreur)
                            {
                                Console.WriteLine("Une erreur s'est produite, réessayez.");
                                encore = true;
                            }

                        } while (encore == true);

                    }
                    else
                    {
                        if (!rep.Equals("NON"))
                        {
                            Console.WriteLine("Invalide");
                            erreur1 = true;
                        }
                        
                    }

                }
                catch (Exception error)
                {
                    erreur1 = true;
                }

            } while (erreur1 == true);

            Console.ReadKey();

        }
    }
}
