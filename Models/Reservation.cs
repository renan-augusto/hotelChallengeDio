using System;
using hotelChallengeDio;

namespace hotelChallengeDio.Models
{
    public class Reservation
    {
        public List<Person> Guests { set; get; }
        public Suite Suite { set; get; }
        public int DaysReservation { set; get; }

        public void InputGuests(List<Person> guests)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (true)
            {
                Guests = guests;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
            }
        }

        public void InputSuite(Suite suite)
        {
            Suite = suite;    
        }
        public void DisplayGuestsQtd()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return 0;
        }
        public decimal PriceCalculator()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;  
             // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (true)
            {
                valor = 0;
            } 
            return valor;     
        }

    }
}