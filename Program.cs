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
            //DateTime today = DateTime.Now;
            DateTime today = new DateTime(2019,6,24,10,0,0);

            //Instansiation du message avec la date en paramètre
            Message message = new Message(today);
            //Utilisation du Getter pour récupérer le message
            String helloMessage = message.GetHelloMessage();

            //Valeur null par defaut
            int exit = 0;

            //Bouvle d'affichage du message
            while (exit == 0)
            {
                //Affiche le message dans la console
                Console.WriteLine(helloMessage);

                //Le programme s'arrete si la touche est différente de Enter, sinon elle reboucle sur l'affichage du message
                if(Console.ReadKey().Key != ConsoleKey.Enter) { exit = 1; }
                else { exit = 0; }  
            }
        }
    }
}
