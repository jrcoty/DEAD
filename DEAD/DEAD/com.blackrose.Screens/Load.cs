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
using Microsoft.Xna.Framework.Input;

using DEAD.com.blackrose.Inputs;
using DEAD.com.blackrose.Main;

namespace DEAD.com.blackrose.Screens
{
    public class Load : Screen
    {
       // private float 


        public Load()
        {
#if DEBUG
            Console.WriteLine("Entered: Load Screen");
#endif
            rect = new Rectangle(17, 65, Globals.Tiles.Size, Globals.Tiles.Size);
            eTime = 0.0f; 
        }

        public override void update(GameTime gameTime) {
            eTime += (float)gameTime.ElapsedGameTime.Milliseconds; 
        }

        public override void draw(SpriteBatch spriteBatch)
        {
            if (eTime < 3000f)
                drawChecks(spriteBatch);
            else
                drawGrid(spriteBatch);

            if (eTime > 4000f) { game.setScreen(new Title()); }
        }

        public override void input(KeyboardState state, bool isKeyDown) {
            if (state.IsKeyDown(Keys.Enter) && !isKeyDown) { game.setScreen(new Title()); }
        }

        private void drawChecks(SpriteBatch spriteBatch)
        {
            if (eTime > 0f) { Globals.Text.Draw(spriteBatch, game.Font(), "RAM:", 50, 20, Globals.Font.Red, 10); }

            if (eTime > 500f) { Globals.Text.Draw(spriteBatch, game.Font(), "OK", 70, 20, Globals.Font.OffWhite, 10); }

            if (eTime > 1000f) { Globals.Text.Draw(spriteBatch, game.Font(), "ROM:", 50, 30, Globals.Font.Red, 10); }

            if (eTime > 2000f) { Globals.Text.Draw(spriteBatch, game.Font(), "OK", 70, 30, Globals.Font.OffWhite, 10); }
        }

        private void drawGrid(SpriteBatch spriteBatch)
        {
            for (int n = 0; n < Globals.Layout.Rows + 3; n++)
                for (int m = 0; m < Globals.Layout.Columns; m++)
                {
                    vector = new Vector2(m * Globals.Tiles.Size, n * Globals.Tiles.Size);

                    spriteBatch.Draw(game.TileSet(), vector, rect, color);
                }
        }
    }
}
