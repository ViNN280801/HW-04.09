using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;

namespace PractiseWork2
{
   public class ServicePerson
    {
        private string path { get; set; }
        public ServicePerson(string path)
        {
            this.path = path;
        }
        public List<Person> ReadFile()
        {
            List<Person> persons = new List<Person>();

            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Person person = new Person();
                    string[] sline = line.Split(';');

                    person.Name = sline[0];
                    person.Surname = sline[1];
                    person.PhoneNumber = sline[2];
                    person.YearOfBirth = int.Parse(sline[3]);

                    persons.Add(person);
                }
                return persons;
            }            
        }
        public void SerializationFileToSoap()
        {
            List<Person> people = new List<Person>(ReadFile());

            SoapFormatter formatter = new SoapFormatter();

            using (FileStream fs = new FileStream("Example.soap", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, people.ToArray());
            }
        }
        public List<Person> DesirializationFile()
        {
            List<Person> people = new List<Person>(ReadFile());

            SoapFormatter formatter = new SoapFormatter();

            using (FileStream fs = new FileStream("Example.soap", FileMode.Open))
            {
                people = (formatter.Deserialize(fs) as Person[]).ToList();
            }

            return people;
        }
    }
}