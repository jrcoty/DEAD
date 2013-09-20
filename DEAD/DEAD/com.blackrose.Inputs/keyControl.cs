// Jonathan Coty
// 4-Aug-2013
// Black Rose Funeral Home

// Controls the key inputs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

using DEAD.com.blackrose.Screens; 

namespace DEAD.com.blackrose.Inputs
{
    static class keyControl
    {
        public static bool isKeyDown; 

        public static void key_press(Screen screen)
        {
            screen.input(Keyboard.GetState());

            if (Keyboard.GetState().IsKeyDown(Keys.Enter) || Keyboard.GetState().IsKeyDown(Keys.Up) || Keyboard.GetState().IsKeyDown(Keys.Down) ||
                Keyboard.GetState().IsKeyDown(Keys.W) || Keyboard.GetState().IsKeyDown(Keys.S))
                isKeyDown = true;
            else
                isKeyDown = false;
        }
    }
}
