using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelingSnake
{
    class Input
    {
        //List of Keyboard Buttons available
        private static Hashtable keyTable = new Hashtable();

        //Event Handling to check if a paticular button is pressed
        public static bool KeyPressed(Keys key)
        {
            if(keyTable[key] == null)
            {
                return false;
            }
         
            return (bool) keyTable[key];
        }

        //Detect if a key is pressed
        public static void ChangeState(Keys key, bool isState)
        {
            keyTable[key] = isState;
        }

    }
}
