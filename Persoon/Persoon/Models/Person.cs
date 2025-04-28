using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Persoon.Models
{
    internal class Person
    {
        public DateTime BirthDate { get; set; }
        public virtual string Data {
            get
            {
                return $"{FullName()} {BirthDate.ToLongDateString()}";
            }
                                    }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string InfoHeader { get;}
        public string Name { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }



        public virtual string FullName() 
        {
            return $"{FirstName} {Name}";
        }

        public virtual void Info(string tekst)
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Uw persoonlijke gegevens:\n");
            sb.AppendLine($"Naam: {FirstName} {Name}");
            sb.AppendLine($"Adres: {Street} {ZipCode}");
            sb.AppendLine($"Gebooredatun: {BirthDate.ToLongDateString()}");
            sb.AppendLine($"E-mail: {tekst}");
            sb.ToString();

            MessageBox.Show($"{sb}", "Info Klasse Persoon", MessageBoxButton.OK);
        }

        public Person()
        {
            
        }


    }
}
