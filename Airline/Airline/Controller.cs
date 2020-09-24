using System;
using System.IO;
namespace Airline
{
    //This is the controller class for the application and is responsible
    //for instantiating the database and user interface as well as calling
    //methods between those classes
    public class Controller
    {
        static MainMenu menu;
        static Database data;

        public static void Main(String[] args)
        {
            data = new Database();
            menu = new MainMenu();
            int userChoice = 0;

            while( userChoice!= 5)
            {
                userChoice = menu.Menu();
                switch (userChoice)
                {
                    case 1:
                        data.addFlight(menu.createFlight());
                        break;
                    case 2:
                        data.viewFlights();
                        break;
                    case 3:
                        string upId = menu.getFlightId();
                        data.updateFlight(upId);
                        data.addFlight(menu.createFlight(upId));
                        break;

                    case 4:
                        data.removeFlight(menu.getFlightId());
                        break;
                    case 5:
                        Environment.Exit(1);
                        break;

                }
            }
        }
    }
}
