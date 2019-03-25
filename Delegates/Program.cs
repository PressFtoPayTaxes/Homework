using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json.Serialization;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите идентификатор персонажа: ");
            int identifier = int.Parse(Console.ReadLine());
            string urlIdentifier = $"https://swapi.co/api/people/{identifier}/";

            string filePath = "characters.xml";

            Character character = new Character();

            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(filePath);
                XmlElement rootElement = xmlDocument.DocumentElement;

                for (int i = 0; i < rootElement.GetElementsByTagName("results").Count; i++)
                {
                    var urlElement = rootElement.GetElementsByTagName("results")[0] as XmlElement;
                    urlElement = urlElement.GetElementsByTagName("url")[i] as XmlElement;
                    if (urlElement.InnerText == urlIdentifier)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Character));
                        character = serializer.Deserialize(stream, );

                    }
                }


            }
        }
    }
}
