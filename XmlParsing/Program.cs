using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            //string xmlUrl = "https://habr.com/ru/rss/interesting/";

            //XmlDocument document = new XmlDocument();
            //document.Load(xmlUrl);

            //List<Item> items = new List<Item>();

            //XmlElement rootElement = document.DocumentElement;

            //for (int i = 0; i < rootElement.ChildNodes[0].ChildNodes.Count; i++)
            //{
            //    var currentItemElement = rootElement.ChildNodes[0].ChildNodes[i] as XmlElement;

            //    if (currentItemElement.Name != "item")
            //        continue;

            //    var titleElement = currentItemElement.GetElementsByTagName("title")[0] as XmlElement;
            //    var linkElement = currentItemElement.GetElementsByTagName("link")[0] as XmlElement;
            //    var descriptionElement = currentItemElement.GetElementsByTagName("description")[0] as XmlElement;
            //    var pubDateElement = currentItemElement.GetElementsByTagName("pubDate")[0] as XmlElement;

            //    items.Add(new Item()
            //    {
            //        Title = titleElement.InnerText,
            //        Link = linkElement.InnerText,
            //        Description = descriptionElement.InnerText,
            //        PubDate = pubDateElement.InnerText
            //    });
            //}


            // 2

            XmlDocument xmlDocument = new XmlDocument();
            var rootElement = xmlDocument.CreateElement("student");

            var idElement = xmlDocument.CreateElement("fio");
            idElement.InnerText = "Зубенко Михаил Петрович";
            rootElement.AppendChild(idElement);

            var nameElement = xmlDocument.CreateElement("facultyName");
            nameElement.InnerText = "Факультет экономики";
            rootElement.AppendChild(nameElement);

            var latitudeElement = xmlDocument.CreateElement("averageMark");
            latitudeElement.InnerText = string.Concat(10.4);
            rootElement.AppendChild(latitudeElement);

            var longitudeElement = xmlDocument.CreateElement("hasDebts");
            longitudeElement.InnerText = string.Concat(false);
            rootElement.AppendChild(longitudeElement);

            xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null));
            xmlDocument.AppendChild(rootElement);

            xmlDocument.Save("student1.txt");

        }
    }
}
