using System;
using System.Collections.Generic;
using System.IO;

namespace Airline
{
    //This is the database class for this application
    //This class is responsible for CRUD actions to the flight database
    public class Database
    {

        //This method takes a Flight object and adds it to the flat file
        public void addFlight(Flight flight)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"Flights.txt", true))
            {
                string line = flight.Origin + " "
                                + flight.Destination + " "
                                + flight.passengers + " "
                                + flight.Id;
                file.WriteLine(line);
            }
        }

        //This method reads flights from the flat file and displays them
        public void viewFlights()
        {
            Console.WriteLine("Origin | Destination| Passengers| Id");
            Console.WriteLine("");
            int counter = 0;
            string line;
            //string path = Path.Combine(Environment.CurrentDirectory, "Flights.txt");
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"Flights.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

            file.Close();
            Console.WriteLine("");

            if (counter == 0)
            {
                System.Console.Write("There are no flights!");
            }
            else
            {
                System.Console.WriteLine("There are {0} flights.", counter);
            }

            Console.WriteLine("Press Enter/Return to continue.");
            Console.ReadLine();
        }

        //this method takes a flight ID and updates the information
        public void updateFlight(String Id)
        {

            String[] lines = System.IO.File.ReadAllLines(@"Flights.txt");
            List<String> newLines = new List<string>();

            foreach (String line in lines)
            {
                if (!line.Contains(Id))
                {
                    newLines.Add(line);
                }
            }

            System.IO.File.WriteAllLines(@"Flights.txt", newLines);
        }

        //this method takes a flight ID and removes the flight from the flat file
        public void removeFlight(String Id)
        {
            String[] lines = System.IO.File.ReadAllLines(@"Flights.txt");
            List<String> newLines = new List<string>();

            foreach(String line in lines){
                if (!line.Contains(Id))
                {
                    newLines.Add(line);
                }
            }

            System.IO.File.WriteAllLines(@"Flights.txt", newLines);
        }
    }
}
