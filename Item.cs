using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelingSnake
{
    // Item class is used to create the food item and body of the snake it acually a circle
    class Item
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Item()
        {
            X = 0;
            Y = 0;
        }
    }
}
