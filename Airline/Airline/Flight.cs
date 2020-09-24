using System;

namespace Airline
{
    //This is the class for the Flight Object and holds information regarding
    //the flight
    public class Flight
    {
        private static String origin;
        private static String destination;
        private static String id;
        public int passengers;

        //Property for Flight origin
        public String Origin
        {
            get => origin;
            set
            {
                if(value.Length == 4)
                {
                    origin = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Origin must be 4 characters");
                }
            }
        }

        //Property for Flight destination
        public String Destination
        {
            get => destination;
            set
            {
                if (value.Length == 4)
                {
                    destination = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Destination must be 4 characters");
                }
            }
        }

        //Property for Flight id
        public String Id
        {
            get => id;
            set
            {
                if (value.Length == 6)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Id must be 6 characters");
                }
            }
        }
    }
}
