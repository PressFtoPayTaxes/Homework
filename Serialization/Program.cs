using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serialization
{
    class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>();

            books.Add(new Book()
            {
                Name = "Тёмная башня",
                Cost = 2600,
                Author = "Стивен Кинг",
                Year = 2004
            });
            books.Add(new Book()
            {
                Name = "Скотный двор",
                Cost = 1150,
                Author = "Джордж Оруэлл",
                Year = 1945
            });
            books.Add(new Book()
            {
                Name = "Война и мир. Том 1-2",
                Cost = 1300,
                Author = "Лев Толстой",
                Year = 1869
            });
            books.Add(new Book()
            {
                Name = "Ведьмак. Последнее желание",
                Cost = 2150,
                Author = "Анджей Сапковский",
                Year = 1990
            });
            books.Add(new Book()
            {
                Name = "Скотный двор",
                Cost = 1150,
                Author = "Джордж Оруэлл",
                Year = 1945
            });
            books.Add(new Book()
            {
                Name = "Зов ктулху",
                Cost = 1350,
                Author = "Говард Лавкрафт",
                Year = 1928
            });

            BinaryFormatter formatter = new BinaryFormatter();

            string filePath = @"C:\books";
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, books);
            }

            List<Book> emptyBooks = new List<Book>();
            using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                emptyBooks = formatter.Deserialize(stream) as List<Book>;
            }
        }
    }
}
