using System;

namespace Airline
{
    //This class handles the user Interface
    //it is responsible for showing info to the user
    //and reading input from said user
    class MainMenu
    {
        //Method for showing and returning menu selection
        public int Menu()
        {
            Console.Clear();
            Console.WriteLine("Type the related number to choose an option:");
            Console.WriteLine("1) Create Flight");
            Console.WriteLine("2) View Flights");
            Console.WriteLine("3) Update Flight");
            Console.WriteLine("4) Remove Flight");
            Console.WriteLine("5) Exit");

            switch (Console.ReadLine())
            {
                case "1": return 1;
                case "2": return 2;
                case "3": return 3;
                case "4": return 4;
                case "5": return 5;
            }

            return -1;
        }

        //This is the method for displaying and intaking information for creating
        //a new flight
        public Flight createFlight()
        {
            Flight flight = new Flight();

            Console.Clear();
            try
            {
                Console.WriteLine("Insert flight Id (3 letters + 3 numbers): ");
                flight.Id = Console.ReadLine();

                Console.WriteLine("Insert flight origin (4 letters): ");
                flight.Origin = Console.ReadLine();

                Console.WriteLine("Insert flight destination (4 letters): ");
                flight.Destination = Console.ReadLine();

                Console.WriteLine("Insert number of passengers: ");
                String temp = Console.ReadLine();
                if (Int32.TryParse(temp, out int pass)){
                    flight.passengers = pass;
                }
                else
                {
                    Console.WriteLine("You entered an invalid input, would you like to try again? y/n");
                    switch (Console.ReadLine())
                    {
                        case "y":
                           flight = createFlight();
                            break;
                        case "n":
                            Menu();
                            break;
                    }
                }
                    
            } catch (ArgumentOutOfRangeException e)
            {
                createFlight();
            }

            return flight;
        }

        //This is a second method for creating a fight that takes an ID for
        //an existing flight
        //This method is used during the update process
        public Flight createFlight(string Id)
        {
            Flight flight = new Flight();

            Console.Clear();
            try
            {
                flight.Id = Id;

                Console.WriteLine("Insert flight origin: ");
                flight.Origin = Console.ReadLine();

                Console.WriteLine("Insert flight destination: ");
                flight.Destination = Console.ReadLine();

                Console.WriteLine("Insert number of passengers: ");
                String temp = Console.ReadLine();
                if (Int32.TryParse(temp, out int pass))
                {
                    flight.passengers = pass;
                }
                else
                {
                    Console.WriteLine("You entered an invalid input, would you like to try again? y/n");
                    switch (Console.ReadLine())
                    {
                        case "y":
                            flight = createFlight();
                            break;
                        case "n":
                            Menu();
                            break;
                    }
                }

            }
            catch (ArgumentOutOfRangeException e)
            {
                createFlight();
            }

            return flight;
        }

        //This is a basic method for getting a flightId from a user
        //through console input
        public String getFlightId()
        {
            String id;
            Console.Clear();
            Console.WriteLine("Insert the ID of the desired flight: ");
            id = Console.ReadLine();
            Console.Clear();
            return id;
        }
    }
}
