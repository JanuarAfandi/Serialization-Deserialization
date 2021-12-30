using System;
using System.IO;
using Playerdata;

namespace Serializee
{
    class Program
    {
        static void Main(string[] args)
        {
            serial serializer = new serial();
            Playerdata.Dataku data = new Playerdata.Dataku();

            string path = Directory.GetCurrentDirectory() + "/Data Player.bin";
            data.InputData();
            serializer.SerialData(data, path);

            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
    }
}
