using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClientAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new FileServiceClient();

            var files = client.GetFiles("c:\\123");

            foreach (var File in files)
            {
                Console.WriteLine(file.FullName);
            }
            client.StartProccer("calc", "");

            Console.ReadLine();
        }
    }
}
