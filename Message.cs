using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Message
    {
        //Message du week end par defaut
        private String HelloMessage = "Bon Week-end " + Environment.UserName;

        //Constructeur de la classe Message
        public Message(DateTime today, int morning=9, int afternoon=13, int night=18)
        {        
            //HelloMessage égale à Bonjour si un jour de la semaine de 9h à 13h
            if (today.Hour >= morning && today.Hour < afternoon && (int)today.DayOfWeek >= 1 && (int)today.DayOfWeek <= 5)
            {
                HelloMessage = "Bonjour " + Environment.UserName;
            }
            //HelloMessage égale à Von après-midi si un jour de la semaine de 13h à 18h
            else if (today.Hour >= afternoon && today.Hour < night && (int)today.DayOfWeek >= 1 && (int)today.DayOfWeek <= 5)
            {
                HelloMessage = "Bon après-midi " + Environment.UserName;
            }
            else if ( today.Hour >= night && today.Hour < morning && (int)today.DayOfWeek >= 1 && (int)today.DayOfWeek <= 5)
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
