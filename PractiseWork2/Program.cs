using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace PractiseWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            DesirializeFromSoap desirialize = new DesirializeFromSoap();

            EventService.WriteEvent(EventPC.Reset, new PC("hp", "365-57-91", "ft32742", 450));

            ServicePerson servicePerson = new ServicePerson("Example.csv");

            servicePerson.SerializationFileToSoap();

            foreach (Person item in servicePerson.DesirializationFile())
            {
                Console.WriteLine("Name: {0}\nSurname: {1}\nPhone number: {2}\nYearOfBirth - {3}\n", item.Name, item.Surname, item.PhoneNumber, item.YearOfBirth);
            }

            desirialize.DesirializeSoapFile("Example.soap");
        }
    }
}