using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleApp.Models
{
    public class GreetingModels
    {
        public class Greeting
        {
            private String[] greeting =
                  new String[] 
                  { 
                      "Go back to sleep, Rosen Kosakov!",
                      "Good morning, Rosen Kosakov!",
                      "Good afternoon, Rosen Kosakov!",
                      "Good evening, Rosen Kosakov!",
                      "Good night, Rosen Kosakov!"
                  };
            public String GetGreeting(int option)
            {
                if (option >= 1 && option <= 6)
                {
                    return greeting[0];
                }
                else if (option >= 7 && option <= 12)
                {
                    return greeting[1];
                }
                else if (option >= 13 && option <= 17)
                {
                    return greeting[2];
                }
                else if (option >= 18 && option <= 20)
                {
                    return greeting[3];
                }
                else if (option >= 21 && option <= 24)
                {
                    return greeting[4];
                }
                else
                {
                    return "No greeting available, Rosen Kosakov!";
                }
               


            }
        }
    }
}
