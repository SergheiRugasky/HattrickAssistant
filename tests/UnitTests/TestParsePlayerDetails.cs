using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using HattrickApiModel;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class TestParsePlayerDetails 
    {
        [TestCase("20190227145657.xml")]
        public void ParseHattrickApiResponse(string filename)
        {
            var testFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"..\..\..\..\TestFiles\PlayerDetails\20190227145657.xml");
            using (var fileStream = File.Open(testFilePath, FileMode.Open))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                var serializer = new XmlSerializer(typeof(HattrickData));
                var playerDetails = serializer.Deserialize(reader);
            }
        }
    }
}
