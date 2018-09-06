using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using ClassLib;

namespace PractiseWork2
{
    public class DesirializeFromSoap
    {
        public void DesirializeSoapFile(string path)
        {

            SoapFormatter formatter = new SoapFormatter();

            using (FileStream fs = new FileStream("Example.soap", FileMode.Open))
            {
                Person obj = formatter.Deserialize(fs) as Person;
            }
        }
}
}