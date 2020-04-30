using System;
using System.Globalization;
using TestConsole.Loggers;
using System.Diagnostics;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logger log = new TextFileLogger("text.log");
            //Logger log = new ConsoleLogger();
            //Logger log = new DebugOutputLogger();
            //Logger log = new TraceLogger();


            Trace.Listeners.Add(new TextWriterTraceListener("logger.log"));
            Trace.Listeners.Add(new XmlWriterTraceListener("logger.log.xml"));

            CombineLogger log = new CombineLogger();
            log.Add(new CombineLogger());
            log.Add(new DebugOutputLogger());
            log.Add(new TraceLogger());
            log.Add(new TextFileLogger("new_log.log"));

            log.LogInformation("Messge1");
            log.LogWarning("Info message");
            log.LogError("Error message");

            
            ComputerLongDataValue(100, log);

            Console.WriteLine("Программа завершена!");
            Console.ReadLine();

            log.Flush();


        }

        private static double ComputerLongDataValue(int Count, Logger Log)
        {
            var result = 0;
            for (var i = 0; i < Count; i++)
            {
                result++;
                Log.LogInformation($"Вычисление итерации{i}");
                System.Threading.Thread.Sleep(100);
            }

            return result;
        }
    }            
}
