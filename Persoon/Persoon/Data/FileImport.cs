using Microsoft.Win32;
using Persoon.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persoon.Data
{
    internal static class FileImport
    {
        public static List<Lector> ReadLector(string fileName)
        {
            try
            {
                List<Lector> lectors = new List<Lector>();
                OpenFileDialog ofd = new OpenFileDialog
                {
                    InitialDirectory = Path.GetFullPath(@"C:\Users\Tolga Guclu\Desktop\Programmeren\C# Advanced\Repos\Hoofdstuk 6 - Inheritance\Persoon"),
                    FileName = "Lectoren.csv"
                };
                if (ofd.ShowDialog() == true)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string[] lineDetails;
                        while (!sr.EndOfStream)
                        {
                            lineDetails = sr.ReadLine().Split(';');
                            lectors.Add(new Lector {
                                Name = lineDetails[0],
                                FirstName = lineDetails[1],
                                BirthDate = DateTime.Parse(lineDetails[2]),
                                Street = lineDetails[3],
                                ZipCode = lineDetails[4],
                                Statute = lineDetails[5],
                                Department = lineDetails[6],
                                InService = DateTime.Parse(lineDetails[7])
                            });
                        }
                    }
                }
                return lectors;
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message);
            }
        }


        public static List<Student> ReadStudent(string fileName)
        {
            List<Student> students = new List<Student>();
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    InitialDirectory = Path.GetFullPath(@"C:\Users\Tolga Guclu\Desktop\Programmeren\C# Advanced\Repos\Hoofdstuk 6 - Inheritance\Persoon"),
                    FileName = "studenten.csv"
                };
                if (ofd.ShowDialog() == true)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string[] lineDetails;

                        while (!sr.EndOfStream)
                        {
                            lineDetails = sr.ReadLine().Split(';');
                            students.Add(new Student
                            {
                                Name = lineDetails[0],
                                FirstName = lineDetails[1],
                                Street = lineDetails[2],
                                ZipCode = lineDetails[3],
                                Paid = char.Parse(lineDetails[4]),
                                Course = lineDetails[5],
                                StudentType = lineDetails[6],
                                StudyPoints = string.IsNullOrWhiteSpace(lineDetails[7]) ? (int?)null : int.Parse(lineDetails[7])

                            });
                        }
                    }
                }
                return students;
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message);
            }
        }

        }
}
