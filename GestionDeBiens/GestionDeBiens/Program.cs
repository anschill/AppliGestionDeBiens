using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeBiens
{
    class Program
    {
        //Création d'une liste de biens
        static List<Realty> realties;

        static void Main(string[] args)
        {
            //On déclare une liste de type Realty pour pouvoir stocker tous les objets dans celle-ci
            realties = new List<Realty>();

            //Appelle la methode pour afficher le menu
            //On stocke le return de la méthode dans la variable choice
            int choice = DisplayMenu();
            //Tant que le choix est différent de 6, on applique la méthode
            //Si choice = 6, on quitte l'application
            while (choice != 6)
            {
                switch (choice)
                {
                    case 1:
                        ListRealty();
                        break;
                    case 2:
                        AddFlat();
                        break;
                    case 3:
                        AddHome();
                        break;
                    case 4:
                        AddParking();
                        break;
                    case 5:
                        DeleteRealty();
                        break;
                }
                choice = DisplayMenu();
            }
        }

        private static void DeleteRealty()
        {
            ListRealty();
            Console.Write("\nQuel bien souhaitez vous supprimer ? ");
            int registerNumber = GetValidNumber();
            int index = GetRealtyIndex(registerNumber);
            if (index >= 0)
            {
                realties.RemoveAt(index);
                Console.WriteLine("Le bien numéro {0} a été supprimé.", registerNumber);
            }
            else
                Console.WriteLine("Le bien que vous essayez de supprimer n'existe pas.");
        }

        private static int GetRealtyIndex(int registerNumber)
        {
            int index = -1;
            foreach (Realty realty in realties)
            {
                if (registerNumber == realty.registerNumber)
                {
                    return index = realties.IndexOf(realty);
                }
            }
            return index;

        }

        private static void AddParking()
        {
            Console.WriteLine("Ajouter un parking :\n");
            Console.Write("Numéro d'enregistrement : ");
            //On teste la validité  du nombre
            int registerNumber = RegisterNumberIsValid();
            Console.Write("Localisation : ");
            String location = Console.ReadLine();
            Console.Write("Superficie : ");
            //On vérifie que le nombre n'est pas null
            int area = GetValidNotNullNumber();
            Console.Write("Loyer : ");
            double rent = GetValidDouble();
            //On crée un objet de type Flat et on lui passe les paramètres
            Parking parking = new Parking(registerNumber, location, area, rent);
            //On ajoute un Flat dans la liste realties de type Realty
            realties.Add(parking);
            Console.WriteLine("Le parking numéro {0} a été ajouté.", registerNumber);
        }

        private static void AddHome()
        {
            Console.WriteLine("Ajouter une maison :\n");
            Console.Write("Numéro d'enregistrement : ");
            //On teste la validité  du nombre
            int registerNumber = RegisterNumberIsValid();
            Console.Write("Localisation : ");
            String location = Console.ReadLine();
            Console.Write("Superficie : ");
            //On vérifie que le nombre n'est pas null
            int area = GetValidNotNullNumber();
            Console.Write("Loyer : ");
            double rent = GetValidDouble();
            Console.Write("Nombre de pièces : ");
            int rooms = GetValidNotNullNumber();
            //On crée un objet de type Flat et on lui passe les paramètres
            Home home = new Home(registerNumber, location, area, rent, rooms);
            //On ajoute un Flat dans la liste realties de type Realty
            realties.Add(home);
            Console.WriteLine("La maison numéro {0} a été ajoutée.", registerNumber);
        }

        private static void AddFlat()
        {
            Console.WriteLine("Ajouter un appartement :\n");
            Console.Write("Numéro d'enregistrement : ");
            //On teste la validité  du nombre
            int registerNumber = RegisterNumberIsValid();
            Console.Write("Localisation : ");
            String location = Console.ReadLine();
            Console.Write("Superficie : ");
            //On vérifie que le nombre n'est pas null
            int area = GetValidNotNullNumber();
            Console.Write("Loyer : ");
            double rent = GetValidDouble();
            Console.Write("Etage : ");
            int floor = GetValidNumber();
            Console.Write("Nombre de pièces : ");
            int rooms = GetValidNotNullNumber();
            //On crée un objet de type Flat et on lui passe les paramètres
            Flat flat = new Flat(registerNumber, location, area, rent, rooms, floor);
            //On ajoute un Flat dans la liste realties de type Realty
            realties.Add(flat);
            Console.WriteLine("L'appartement numéro {0} a été ajouté.", registerNumber);
        }

        private static int RegisterNumberIsValid()
        {

            while (true)
            {
                int registerNumber = GetValidNumber();
                int index = GetRealtyIndex(registerNumber);
                if (index != -1)
                {
                    Console.WriteLine("Le numéro d'enregistrement est déjà utilisé, réésayez");
                }
                else
                    return registerNumber;
            }
        }

        private static double GetValidDouble()
        {
            //Tant que la valeur entrée n'est pas un nombre, on demande d'en entrer un.
            while (true)
            {
                double number;
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                        return number;
                }
            }
        }

        private static int GetValidNotNullNumber()
        {
            while (true)
            {
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0)
                        return number;
                }
            }
        }

        private static int GetValidNumber()
        {
            while (true)
            {
                int number;
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
            }
        }

        private static void ListRealty()
        {
            Console.WriteLine("Liste des biens :\n");
            //Pour chaque bien de type Realty qui est dans la liste realties
            foreach (Realty realty in realties)
            {
                Console.WriteLine(realty + "\n");
            }
        }

        private static int DisplayMenu()
        {
            //Tant que la methode n'a rien retourné
            while (true)
            {
                Console.WriteLine("Menu de l'application : \n");
                Console.WriteLine("Le nombre de biens est de : {0}", realties.Count);
                Console.WriteLine("1 : Afficher la liste des biens.");
                Console.WriteLine("2 : Ajouter un appartement.");
                Console.WriteLine("3 : Ajouter une maison.");
                Console.WriteLine("4 : Ajouter un parking.");
                Console.WriteLine("5 : Supprimer un bien.");
                Console.WriteLine("6 : Quitter l'application.");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice >= 1 && choice <= 6)
                    {
                        return choice;
                    }
                }
                Console.Clear();
            }
        }
    }
}
