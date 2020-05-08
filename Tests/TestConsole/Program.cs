using System;
using System.Globalization;
using TestConsole.Loggers;
using System.Diagnostics;
using System.Runtime.Serialization;
using TestConsole.Service;
using System.Collections.Generic;
using System.IO;

namespace TestConsole
{   
    class Program
    {
        private const string __NamesFile = "Names.txt";

        static void Main(string[] args)
        {
            foreach (var student in GetStudents(__NamesFile))
                Console.WriteLine(student.SurName + " " + student.Name + " " + student.Patronimyc);


            Console.ReadLine();
        }
      
        public static IEnumerable<Student> GetStudents(string FileName)
        {
            //yield break;
            //yield return new Student();

            using(var file = File.OpenText(FileName))
            {
                while (!file.EndOfStream)
                {
                    var line = file.ReadLine();

                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var components = line.Split(' ');
                    if (components.Length != 3) continue;

                    var student = new Student();
                    student.SurName = components[0];
                    student.Name = components[1];
                    student.Patronimyc = components[2];

                    yield return student;
                }
            }
        }
    }




}
