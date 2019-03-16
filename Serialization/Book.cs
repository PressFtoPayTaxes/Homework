using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
