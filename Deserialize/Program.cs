using System;
using System.IO;
using Playerdata;

namespace Deserializee
{
    class Program
    {
        static void Main(string[] args)
        {
            Deserialized deserializer = new Deserialized();

            string path = Directory.GetCurrentDirectory() + "/Data Player.bin";

            Playerdata.Dataku data = deserializer.DeserializeData(path);

            data.ShowData();

            Console.WriteLine("Press Any Key");
            Console.ReadKey();
        }
    }
}
