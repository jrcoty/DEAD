// Jonathan Coty
// 19-Sep-2013
// Black Rose Funeral Home

// Controls the keyboard inputs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

using DEAD.com.blackrose.Screens; 

namespace DEAD.com.blackrose.Inputs
{
    class Input
    {
        private bool isKeyDown; 
        
        public Input() { 
            isKeyDown = false; 
        }

        public void keyPress(Screen screen)
        {
            screen.input(Keyboard.GetState(), isKeyDown);

            if (Keyboard.GetState().IsKeyDown(Keys.Enter) || Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.Down) ||
                Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.S))
                isKeyDown = true;
            else
                isKeyDown = false;
        }

        public void mouseClick()
        {

        }

        public bool isKeyPressed() {
            return isKeyDown; 
        }
    }
}
