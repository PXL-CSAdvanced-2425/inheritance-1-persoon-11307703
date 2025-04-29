using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persoon.Models
{
    internal class Student : Person
    {
        private int? _studyPoints;

        public int? StudyPoints
        {
            get { return _studyPoints; }
            set
            {
                if ((value < 0 || value > 99))
                {
                    throw new ArgumentOutOfRangeException("Points must be between 0 and 99");
                }
                else if (value.HasValue)
                {
                    _studyPoints = value;
                }
                else
                {
                    _studyPoints = 60;
                }
            }
        }

        public string Course { get; set; }
        public char Paid { get; set; }
        public string StudentType { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public float SubscriptionAmount
        {
            get
            {
                if (StudentType == "I") 
                {
                    return 50f + (8.66667f * (StudyPoints?? 0));
                }
                else 
                {
                    return 520.00f;
                }
            }
        }
        public override string Data { get { return $"{StudentType} {Paid} {SubscriptionAmount}"; } }

        public Student()
        {
            this.StartDate = DateTime.Now;
        }


        public override void Info(string tekst)
        {
            base.Info(tekst);
        }

        public string PrintStartDate()
        {
           return $"{base.FullName()} + {this.StartDate}";
        }

        public string PrintAddress()
        {
            return $"{base.FullName()} + {base.Street} + {base.ZipCode}";
        }

        public override string ToString()
        {
            if (this.StudentType == "I")
            {
                return $"{this.FirstName} {this.Name} Student met individueel traject: {this.StudyPoints}SP - Inschrijvingsgeld: €{this.SubscriptionAmount.ToString("F2")} : Betaald: {this.Paid}";
            }
            else
            {
                return $"{this.FirstName} {this.Name} Standaardstudent: {this.StudyPoints}SP - Inschrijvingsgeld: €{this.SubscriptionAmount.ToString("F2")} : Betaald: {this.Paid}";
            }
        }
    }
}
