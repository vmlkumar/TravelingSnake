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
        //List of Keyboard Buttons available or pressed by the users will be stored in this
        //private static Dictionary<Keys, bool> keyTable = new Dictionary<Keys, bool>();
        private static Hashtable keyTable = new Hashtable();

        //Event Handling to check if a paticular button is pressed
        public static bool KeyPressed(Keys key)
        {
            if(keyTable[key] == null)
            {
                return false;
            }

            // return the ture or false if not 
            return (bool) keyTable[key];
           
            //return true;
        }

        //Detect if a key is pressed
        public static void ChangeState(Keys key, bool isPressedState)
        {
            keyTable[key] = isPressedState;
        }

    }
}
