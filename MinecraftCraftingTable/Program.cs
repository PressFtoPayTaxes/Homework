using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftCraftingTable
{
    class Program
    {
        public enum Materials
        {
            nothing = 0,
            wood,
            rock,
            stick,
            gold,
            iron
        }
        public enum Keys
        {
            arrowLeft = 0x25,
            arrowUp,
            arrowRight,
            arrowDown,
            zero = 0x30,
            one,
            two,
            three,
            four,
            five,
            enter = 0x0D,
            esc = 0x1B
        }
        static void Main(string[] args)
        {
            const int recipesCount = 20;
            Recipe[] recipes = new Recipe[recipesCount];
            for (int i = 0; i < recipesCount; i++)
            {
                recipes[i] = new Recipe();
            }
            #region Set Recipes
            recipes[0].SetRecipe("Деревянная лопата", (int)Materials.nothing, (int)Materials.wood, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[1].SetRecipe("Каменная лопата", (int)Materials.nothing, (int)Materials.rock, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[2].SetRecipe("Золотая лопата", (int)Materials.nothing, (int)Materials.gold, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[3].SetRecipe("Железная лопата", (int)Materials.nothing, (int)Materials.iron, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[4].SetRecipe("Деревянная кирка", (int)Materials.wood, (int)Materials.wood, (int)Materials.wood, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[5].SetRecipe("Каменная кирка", (int)Materials.rock, (int)Materials.rock, (int)Materials.rock, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[6].SetRecipe("Золотая кирка", (int)Materials.gold, (int)Materials.gold, (int)Materials.gold, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[7].SetRecipe("Деревянная кирка", (int)Materials.iron, (int)Materials.iron, (int)Materials.iron, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[8].SetRecipe("Деревянная мотыга", (int)Materials.wood, (int)Materials.wood, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[9].SetRecipe("Каменная мотыга", (int)Materials.rock, (int)Materials.rock, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[10].SetRecipe("Золотая мотыга", (int)Materials.gold, (int)Materials.gold, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[11].SetRecipe("Железная мотыга", (int)Materials.iron, (int)Materials.iron, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[12].SetRecipe("Деревянный топор", (int)Materials.wood, (int)Materials.wood, (int)Materials.nothing, (int)Materials.wood, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[13].SetRecipe("Каменный топор", (int)Materials.rock, (int)Materials.rock, (int)Materials.nothing, (int)Materials.rock, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[14].SetRecipe("Золотой топор", (int)Materials.gold, (int)Materials.gold, (int)Materials.nothing, (int)Materials.gold, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[15].SetRecipe("Железный топор", (int)Materials.iron, (int)Materials.iron, (int)Materials.nothing, (int)Materials.iron, (int)Materials.stick, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[16].SetRecipe("Деревянный меч", (int)Materials.nothing, (int)Materials.wood, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.wood, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[17].SetRecipe("Каменный меч", (int)Materials.nothing, (int)Materials.rock, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.rock, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[18].SetRecipe("Золотой меч", (int)Materials.nothing, (int)Materials.gold, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.gold, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            recipes[19].SetRecipe("Железный меч", (int)Materials.nothing, (int)Materials.iron, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.iron, (int)Materials.nothing, (int)Materials.nothing, (int)Materials.stick, (int)Materials.nothing);
            #endregion

            Recipe yourRecipe = new Recipe();
            Print();
            int[] cursorPositionsX = { 2, 6, 10 };
            int[] cursorPositionsY = { 1, 3, 5 };

            int xPositionsDifference = cursorPositionsX[2] - cursorPositionsX[1];
            int yPositionsDifference = cursorPositionsY[2] - cursorPositionsY[1];

            int cursorPositionX = cursorPositionsX[0];
            int cursorPositionY = cursorPositionsY[0];
            const int columns = 3;
            int selectedCell = 1;

            const int finalPositionX = 0;
            int finalPositionY = 16;
            while (true)
            {
                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                int key = (int)Console.ReadKey(true).Key;
                //Console.WriteLine(key);
                switch (key)
                {
                    case (int)Keys.arrowLeft:
                        {
                            if (cursorPositionX > cursorPositionsX[0])
                            {
                                cursorPositionX -= xPositionsDifference;
                                selectedCell--;
                            }
                            break;
                        }
                    case (int)Keys.arrowUp:
                        {
                            if (cursorPositionY > cursorPositionsY[0])
                            {
                                cursorPositionY -= yPositionsDifference;
                                selectedCell -= columns;
                            }
                            break;
                        }
                    case (int)Keys.arrowRight:
                        {
                            if (cursorPositionX < cursorPositionsX[2])
                            {
                                cursorPositionX += xPositionsDifference;
                                selectedCell++;
                            }
                            break;
                        }
                    case (int)Keys.arrowDown:
                        {
                            if (cursorPositionY < cursorPositionsY[2])
                            {
                                cursorPositionY += yPositionsDifference;
                                selectedCell += columns;
                            }
                            break;
                        }
                    case (int)Keys.zero:
                        {
                            Console.WriteLine(' ');
                            yourRecipe.AddCell((int)Materials.nothing, selectedCell - 1);
                            break;
                        }
                    case (int)Keys.one:
                        {
                            Console.WriteLine((int)Materials.wood);
                            yourRecipe.AddCell((int)Materials.wood, selectedCell - 1);
                            break;
                        }
                    case (int)Keys.two:
                        {
                            Console.WriteLine((int)Materials.rock);
                            yourRecipe.AddCell((int)Materials.rock, selectedCell - 1);
                            break;
                        }
                    case (int)Keys.three:
                        {
                            Console.WriteLine((int)Materials.stick);
                            yourRecipe.AddCell((int)Materials.stick, selectedCell - 1);
                            break;
                        }
                    case (int)Keys.four:
                        {
                            Console.WriteLine((int)Materials.gold);
                            yourRecipe.AddCell((int)Materials.gold, selectedCell - 1);
                            break;
                        }
                    case (int)Keys.five:
                        {
                            Console.WriteLine((int)Materials.iron);
                            yourRecipe.AddCell((int)Materials.iron, selectedCell - 1);
                            break;
                        }
                    case (int)Keys.enter:
                        {
                            Console.SetCursorPosition(finalPositionX, finalPositionY);
                            Console.WriteLine("Поздравляем!!! Вы создали предмет: " + CreateItem(yourRecipe, recipes));
                            finalPositionY++;
                            break;
                        }
                    case (int)Keys.esc:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }

        public static string CreateItem(Recipe recipe, Recipe[] templates)
        {
            for (int i = 0; i < templates.Length; i++)
            {
                if (recipe == templates[i])
                {
                    return templates[i].Name;
                }
            }
            return "Абсолютно ничего";
        }

        public static void Print()
        {
            Console.WriteLine("+---+---+---+");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("+---+---+---+");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("+---+---+---+");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("+---+---+---+");
            Console.WriteLine("Ставьте материалы с помощью цифр:");
            Console.WriteLine("0 - стереть");
            Console.WriteLine("1 - дерево");
            Console.WriteLine("2 - камень");
            Console.WriteLine("3 - палка");
            Console.WriteLine("4 - золото");
            Console.WriteLine("5 - железо");
            Console.WriteLine("enter - крафт");
            Console.WriteLine("esc - выход");
        }
    }
}
