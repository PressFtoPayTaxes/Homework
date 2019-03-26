using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEventsPractic
{
    public delegate void PropertyEventHandler(object sender, TestClass e);
    public class TestClass : IPropertyChanged
    {
        public event PropertyEventHandler PropertyChanged;
        public string User { get; set; } = "Игорь";
        private string testProperty;
        public string TestProperty
        {
            get
            {
                return testProperty;
            }
            set
            {
                PropertyChanged?.Invoke(User, this);
                testProperty = value;
            }
        }
    }
}
