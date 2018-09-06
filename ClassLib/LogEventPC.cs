using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public enum EventPC { On, Off, Reset }
    public class LogEventPC
    {
        public DateTime EventDate { get; set; }
        public EventPC EventPC { get; set; }
        public PC pc {get;set;}
    }
    public class PC
    {
        public string Firm { get; set; }
        public string PhoneNumber { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public PC() { }
        public PC(string firm, string phoneNumber, string model, int price)
        {
            Firm = firm;
            PhoneNumber = phoneNumber;
            Model = model;
            Price = price;
        }
    }
}