using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCraftingTable
{
    class Cell
    {
        public int Material { get; set; }
        public int Position { get; set; }

        public static Recipe operator +(Cell firstMaterial, Cell secondMaterial)
        {
            Recipe recipe = new Recipe();
            recipe.AddCell(firstMaterial.Material, firstMaterial.Position);
            return recipe;
        }
    }
}
