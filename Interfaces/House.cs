using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class House
    {
        public Basement basement { get; set; }
        public Wall[] walls { get; set; }
        public Door door { get; set; }
        public Window[] windows { get; set; }
        public Roof roof { get; set; }
        public House()
        {
            basement = new Basement();
            walls = new Wall[4];
            for (int i = 0; i < walls.Count(); i++)
            {
                walls[i] = new Wall();
            }
            door = new Door();
            windows = new Window[4];
            for (int i = 0; i < windows.Count(); i++)
            {
                windows[i] = new Window();
            }
            roof = new Roof();
        }
    }
}
