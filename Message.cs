using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Message
    {
        //Création des 3 DateTime avec les horaires de délimitages 9h, 13h et 18h
        DateTime morning = new DateTime(2018, 6, 19, 9, 0, 0);
        DateTime afternoon = new DateTime(2018, 6, 19, 13, 0, 0);
        DateTime night = new DateTime(2018, 6, 19, 18, 0, 0);

        //Message du week end par defaut
        private String HelloMessage = "Bon Week-end " + Environment.UserName;

        //Constructeur de la classe Message
        public Message(DateTime maintenant)
        {
            //HelloMessage égale à Bonjour si un jour de la semaine de 9h à 13h
            if (maintenant.Hour> morning.Hour && maintenant.Hour < afternoon.Hour && (int)maintenant.DayOfWeek >= 1 && (int)maintenant.DayOfWeek <= 5)
            {
                HelloMessage = "Bonjour " + Environment.UserName;
            }
            //HelloMessage égale à Von après-midi si un jour de la semaine de 13h à 18h
            else if (maintenant.Hour > afternoon.Hour && maintenant.Hour < night.Hour && (int)maintenant.DayOfWeek >= 1 && (int)maintenant.DayOfWeek <= 5)
            {
                HelloMessage = "Bon après-midi " + Environment.UserName;
            }
            else if ( maintenant.Hour > night.Hour && maintenant.Hour < morning.Hour && (int)maintenant.DayOfWeek >= 1 && (int)maintenant.DayOfWeek <= 5)
            //HelloMessage égale à Von après-midi si un jour de la semaine de 18h à 9h
            {
                HelloMessage = "Bonsoir " + Environment.UserName;
            }
        }

        //Getter pour récupérer la variable String de HelloMessage dans la main
        public String GetHelloMessage()
        {
            return this.HelloMessage;
        }
    }
}
