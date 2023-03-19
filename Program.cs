using System.Text;
using hotelChallengeDio;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> guests = new List<Pessoa>();

Person p1 = new Person(name: "Renan Augusto");
Person p2 = new Person(name: "Fernanda Lavezzo");

guests.Add(p1);
guests.Add(p2);

Suite suite = new Suite(SuiteType: "Convencional", Capacity: 3, price: 90);

Reservation reservation = new Reservation(DaysReservation: 5);
reservation.InputSuite(suite);
reservation.InputGuests(guests);

System.Console.WriteLine($"Hospedes: {reservation.DisplayGuestsQtd()}");
System.Console.WriteLine($"Preco diaria: {reservation.PriceCalculator()}");