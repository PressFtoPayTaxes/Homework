using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCraftingTable
{
    class Recipe
    {
        public string Name { get; set; }
        private int[] _completedItem;
        const int fieldSize = 9;

        public Recipe()
        {
            _completedItem = new int[fieldSize];
            for (int i = 0; i < fieldSize; i++)
            {
                _completedItem[i] = 0;
            }
            Name = "Recipe";
        }

        public Recipe(string name, params int[] cells)
        {
            _completedItem = new int[fieldSize];
            SetRecipe(name, cells);
        }

        public bool SetRecipe(string name, params int[] cells)
        {
            if (cells.GetLength(0) != fieldSize)
            {
                return false;
            }
            for (int i = 0; i < fieldSize; i++)
            {
                _completedItem[i] = cells[i];
            }
            Name = name;
            return true;
        }

        public void AddCell(int material, int position)
        {
            _completedItem[position] = material;
        }

        public static bool operator ==(Recipe firstRecipe, Recipe secondRecipe)
        {
            for (int i = 0; i < fieldSize; i++)
            {
                if (firstRecipe._completedItem[i] != secondRecipe._completedItem[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator !=(Recipe firstRecipe, Recipe secondRecipe)
        {
            for (int i = 0; i < fieldSize; i++)
            {
                if (firstRecipe._completedItem[i] == secondRecipe._completedItem[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static Recipe operator +(Recipe uncompletedRecipe, Cell newCell)
        {
            uncompletedRecipe.AddCell(newCell.Material, newCell.Position);
            return uncompletedRecipe;
        }
    }
}
