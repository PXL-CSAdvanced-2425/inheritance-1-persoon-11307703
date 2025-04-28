using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Persoon.Models
{
    internal class Lector : Person
    {
        private string _department;

        public string Department
        {
            get { return _department; }
            set {
                if (value == "SNE")
                {
                    _department = "Systemen en netwerken";
                }
                else if (value == "PRO")
                {
                    _department = "Programmeren";
                }
                else if (value == "DVG")
                {
                    _department = "Digitale Vormgeving";
                }
                else if (value == "IOT")
                {
                    _department = "Internet Of Things";
                }
            }
        }

        public string Statute { get; set; }
        public DateTime InService { get; set; }

        public override string Data { get { return $"{base.FullName()} {this.Statute} {this.Department}"; } }

        public override void Info(string tekst)
        {
            MessageBox.Show($"Gegevens van de lector: {this.PrintInService()}");
        }


        public Lector() 
        {

        }


        public string PrintInService()
        {
            //geeft eigenschap FullName() uit klasse Person + "is in dienst sinds: " + InService (kort datumnotatie)
          return  $"{base.FullName()} is in dienst sinds: {this.InService}";
        }

        public string PrintAdress()
        {
            //PrintAddress(): geeft FullName() uit klasse Person + Straat + Postcode
            return $"{base.FullName()} {base.Street} {base.ZipCode}";
        }

        public override string ToString()
        {
            return $"{base.FirstName} {base.Name} - {this.Statute} - {this.Department}";
        }

    }
}
