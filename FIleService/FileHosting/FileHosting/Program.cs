using FileHosting.Interfaces;
using FileHosting.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FileHosting
{
    class Program
    {
        static void Main(string[] args)
        {


            /*var student = new Student
            {
                Name = "Student name",
                Surname = "Student surname",
                Birthday = DateTime.Now
            };
            var binary_formatter = new BinaryFormatter();
            var xml_serializer = new XmlSerializer(typeof(Student));

            using (var bin_file = File.Create("sstudent.bin"))
            using (var xml_file = File.Create("student.xml"))
            {
                binary_formatter.Serialize(bin_file, student);
                xml_serializer.Serialize(xml_file, student);
            }

            Student s1, s2;
            using (var bin_file = File.Open("student.bin", FileMode.Open))
            using (var xml_file = File.Open("student.xml", FileMode.Open))
            {
                s1 = (Student)binary_formatter.Deserialize(bin_file);
                s2 = (Student)xml_serializer.Deserialize(xml_file);*/
            //}

            /*var student = new Student();

            var student_type = student.GetType();

            var student_type2 = typeof(Student);

            var studeny_name = student_type.GetProperty("Name");

            studeny_name.SetValue(student, "Hello, World!");*/

            var host = new ServiceHost(typeof(FileService),
                new Uri("http://localhost:8080/FileService"), //netsh http add urlacl url=http://+:port number/ user=\user name
                new Uri("net.tcp://localhost/FileService"), //netsh advfirewall firewall add name=\"rule_name"\ dir=in actoin=allow protocol=TCP localport=port
                new Uri("net.pipe://localhost/FileService")
                );

            host.AddServiceEndpoint(
                typeof(IFileService),
                new BasicHttpBinding(),
                "http://localhost:8080/FileService");

            host.AddServiceEndpoint(
                typeof(IFileService),
                new NetTcpBinding(),
                "net.tcp://localhost/FileService");

            host.AddServiceEndpoint(
                typeof(IFileService),
                new NetNamedPipeBinding(),
                "net.pipe://localhost/FileService");

            host.Description.Behaviors.Add(new ServiceMetadataBehavior { HttpGetEnabled = true });

            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");
            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexNamedPipeBinding(), "mex");

            host.Open();

            UdpClient udp_client = new UdpClient(8082);

            //TcpClient tcp-client = new TcpClient(new IPEndPoint(IPAdress.Parse("192.168.0.1"), 80));
            TcpClient tcp-client = new TcpClient();
            tcp_client.Connect("192.168.0.1", 80);
            using (var reader = new StreamReader(tcp_client.GetStream()))
            {
                while (!reader.EndOfStream)
                    Console.WriteLine(reader.ReadLine());
            }

            Console.WriteLine("Хост запущен успешно!");
            Console.ReadLine();
        }
    }

    /* [Serializable]
     internal class Student
     {
         public string Name { get; set; }
         public string Surname { get; set; }
         public DateTime Birthday { get; set; }
         public XmlSchema GetSchema() => null;
     }*/
}

