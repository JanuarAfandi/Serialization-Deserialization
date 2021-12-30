using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Playerdata
{
    public class Deserialized
    {

        public Dataku DeserializeData(string path)
        {
            Dataku data = new Dataku();

            if (File.Exists(path))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                FileStream stream = new FileStream(path, FileMode.Open);

                data = formatter.Deserialize(stream) as Dataku;

                stream.Close();
            }
            else
            {
                Console.WriteLine("No File Exists");
            }

            return data;
        }
    }
}
