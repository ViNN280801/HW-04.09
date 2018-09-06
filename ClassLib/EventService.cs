using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ClassLib
{
    public class EventService
    {
        public static void WriteEvent(EventPC eventPC, PC pc)
        {
            LogEventPC log = new LogEventPC();

            log.EventPC = eventPC;
            log.pc = pc;
            log.EventDate = DateTime.Now;
            XmlSerializer formatter = new XmlSerializer(typeof(LogEventPC));

            using (FileStream fs = new FileStream(DateTime.Now.Ticks + ".xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, log);
            }
        }
    }
}