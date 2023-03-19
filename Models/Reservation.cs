using System;
using hotelChallengeDio;

namespace hotelChallengeDio.Models
{
    public class Reservation
    {
        public List<Person> Guests { set; get; }
        public Suite Suite { set; get; }
        public int DaysReservation { set; get; }

        public Reservation() { }

        public Reservation(int daysReservation)
        {
            DaysReservation = daysReservation;
        }

        public void InputGuests(List<Person> guests)
        {
            if (Suite.Capacity >= guests.Count)
            {
                Guests = guests;
            }
            else
            {
                throw new Exception("Numero de hospedes excede a capacidade da suite");
            }
        }

        public void InputSuite(Suite suite)
        {
            Suite = suite;    
        }
        public int DisplayGuestsQtd()
        {
            return Guests.Count;   
        }
        public decimal PriceCalculator()
        {
            decimal finalPrice = (decimal)DaysReservation * Suite.Price;  
            
          
            if (DaysReservation >= 10)
            {
                finalPrice = finalPrice * (decimal)0.90;
                return finalPrice;
            } 
            else 
            {
                 return finalPrice;  
            }
              
        }

    }
}