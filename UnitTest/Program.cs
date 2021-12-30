using Playerdata;
using System;
using System.IO;
using Xunit;

namespace UnitTest
{
    public class UnitTest
    {
        Playerdata.Dataku dataTest = new Dataku("Name Test", 50, 35, 4500, 300);
        string path = Directory.GetCurrentDirectory() + "/PlayerTesting.bin";
        [Fact]
        public void SerializeWorkTest()
        {
            serialized serializer = new serialized();
            serializer.SerialData(dataTest, path);
        }

        [Fact]
        public void DeserializeWorkTest()
        {
            Playerdata.Dataku data = new Playerdata.Dataku();
            Deserializer deserializer = new Deserializer();
            data = deserializer.DeserializeData(path);
        }

        [Fact]
        public void IsThereCreatedFileTest()
        {
            bool cond = true;

            if (!File.Exists(path))
            {
                cond = false;
            }
            Assert.True(cond);
        }

        [Fact]
        public void TestEqualData()
        {
            serialized serializer = new serialized();
            serializer.SerialData(dataTest, path);

            Playerdata.Dataku data = new Playerdata.Dataku();
            Deserializer deserializer = new Deserializer();
            data = deserializer.DeserializeData(path);

            bool cond = true;
            if (data.playername != dataTest.playername) cond = false;
            if (data.coin != dataTest.coin) cond = false;
            if (data.level != dataTest.level) cond = false;
            if (data.score != dataTest.score) cond = false;
            Assert.True(cond);
        }
    }
}