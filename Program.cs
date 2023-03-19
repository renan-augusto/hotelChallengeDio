using System.Text;
using hotelChallengeDio.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Person> guests = new List<Person>();

Person p1 = new Person(name: "Renan Augusto");
Person p2 = new Person(name: "Fernanda Lavezzo");

guests.Add(p1);
guests.Add(p2);

Suite suite = new Suite(suiteType: "Convencional", capacity: 3, price: 90);

Reservation reservation = new Reservation(daysReservation: 5);
reservation.InputSuite(suite);
reservation.InputGuests(guests);

System.Console.WriteLine($"Hospedes: {reservation.DisplayGuestsQtd()}");
System.Console.WriteLine($"Preco diaria: {reservation.PriceCalculator()}");