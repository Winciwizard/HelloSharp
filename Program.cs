using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Hello
    {
        static void Main(string[] args)
        {
            //Variables de test : Maintenant et une manuel
            DateTime today = DateTime.Now;
            //DateTime today = new DateTime(2019,6,25,10,0,0);


            //Instansiation du message avec la date en paramètre
            Message message = new Message(today,8,14,19);
            //Utilisation du Getter pour récupérer le message
            String helloMessage = message.GetHelloMessage();

            //Valeur null par defaut
            String menu = "";

            //Bouvle d'affichage du message
            while (menu == "")
            {
                //Affiche le message dans la console
                Console.WriteLine(helloMessage);

                //Le programme s'arrete si la touche est différente de Enter, sinon elle reboucle sur l'affichage du message
                Console.WriteLine("enter to continue or write exit");

                //Récupére la valeur tapé
                String input = Console.ReadLine();

                while (input != "" && menu != "exit")
                {
                    menu = input;
                }
            }

        }
    }
}
