// Jonathan Coty
// 3-Aug-2013
// Black Rose Funeral Home

// "Loads" the game
// Really just for mimicking the self test
// and load sequence of older arcade games, 
// specifically Ghosts n' Goblins

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace DEAD.com.blackrose.Screen
{
    public class Load : Screen
    {
        public Load()
        {
            Console.WriteLine("Entered: Load Screen");

            rect = new Rectangle(69, 35, globals.spriteSize, globals.spriteSize);
            e_Time = 0.0f; 
        }

        public override void update(GameTime gameTime) {
            e_Time += (float)gameTime.ElapsedGameTime.Milliseconds; 
        }

        public override void draw(SpriteBatch spriteBatch)
        {

            if (e_Time < 3000f)
                drawChecks(spriteBatch);
            else
                drawGrid(spriteBatch);


            if (e_Time > 4000f) { game.setScreen(new Title()); }
        }

        private void drawChecks(SpriteBatch spriteBatch)
        {
            if (e_Time > 0f) { Draw_Text(spriteBatch, "RAM:", 50, 20, globals.Red, 10); }

            if (e_Time > 500f) { Draw_Text(spriteBatch, "OK", 70, 20, globals.OWhite, 10); }

            if (e_Time > 1000f) { Draw_Text(spriteBatch, "ROM:", 50, 30, globals.Red, 10); }

            if (e_Time > 2000f) { Draw_Text(spriteBatch, "OK", 70, 30, globals.OWhite, 10); }
        }

        private void drawGrid(SpriteBatch spriteBatch)
        {
            for (int n = 0; n < globals.LayoutRow + 3; n++)
                for (int m = 0; m < globals.LayoutCol; m++)
                {
                    vector = new Vector2(m * globals.spriteSize, n * globals.spriteSize);

                    spriteBatch.Draw(globals.tileset, vector, rect, color);
                }
        }
    }
}
