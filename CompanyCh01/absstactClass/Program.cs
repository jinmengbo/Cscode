using System;
using System.Collections.Generic;

namespace absstactClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PdaItem[] pad = new PdaItem[3];
            Contact contact = new Contact("Sherlock Holmes");
            contact.addres = "221B Baker Street, London, England";
            pad[0] = contact;
            Appointment appointment = new Appointment("Soccer tournament");
            appointment.StartDateTime = new DateTime(2020, 5, 14);
            appointment.EndDateTime = new DateTime(2020, 5, 14);
            appointment.Location = "Estádio da Machava";
            pad[1] = appointment;
            contact = new Contact("nne Fran");
            contact.addres =
               "Apt 56B, Whitehaven Mansions, Sandhurst Sq, London";
            pad[2] = contact;
            List(pad);


        }
        public static void List(PdaItem[] items)
        {
            foreach(PdaItem item in items)
            {
                Console.WriteLine("_____________");
                Console.WriteLine(item.GetSummary());
            }
        }
    }
}
