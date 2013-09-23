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
        private const float MEM_CHECK = 3000f;
        private const float SCREEN_CHECK = 4000f;

        private string[,] DISPLAY = {{"RAM:", "0", "50", "20", "0"}, {"OK", "500", "70", "20", "1"},
                                     {"ROM:", "1000", "50", "30", "0"}, {"OK", "2000", "70", "30", "1"}};
        private Color[] COLORS = {Globals.Font.Red, Globals.Font.OffWhite}; 
        private const int SPACE = 10;

        private const int GRID_X = 17;
        private const int GRID_Y = 65; 

        public Load()
        {
#if DEBUG
            Console.WriteLine("Entered: Load Screen");
#endif
            // Location of the grid tile
            rect = new Rectangle(GRID_X, GRID_Y, Globals.Tiles.Size, Globals.Tiles.Size);
            eTime = 0.0f; 
        }

        public override void update(GameTime gameTime) {
            eTime += (float)gameTime.ElapsedGameTime.Milliseconds; 
        }

        public override void draw(SpriteBatch spriteBatch)
        {
            if (eTime < MEM_CHECK)
                drawChecks(spriteBatch);
            else
                drawGrid(spriteBatch);

            if (eTime > SCREEN_CHECK) { game.setScreen(new Title()); }
        }

        public override void input(KeyboardState state, bool isKeyDown) {
            if (state.IsKeyDown(Keys.Enter) && !isKeyDown) { game.setScreen(new Title()); }
        }

        // Memory "check"
        private void drawChecks(SpriteBatch spriteBatch)
        {  
            for (int n = 0; n < DISPLAY.GetLength(0); n++)
                if (eTime > float.Parse(DISPLAY[n, 1]))
                    Globals.Text.Draw(spriteBatch, game.Font(), DISPLAY[n, 0], int.Parse(DISPLAY[n, 2]), int.Parse(DISPLAY[n, 3]), 
                                        COLORS[int.Parse(DISPLAY[n, 4])], SPACE);
        }

        // Graphics "check"
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
