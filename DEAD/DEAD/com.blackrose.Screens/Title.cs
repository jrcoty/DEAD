// Jonathan Coty
// 3-Aug-2013
// Black Rose Funeral Home

// Title Screen

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

using DEAD.com.blackrose.Main;

namespace DEAD.com.blackrose.Screens
{
    public class Title : Screen
    {
        private string[] MENU = {"START", "OPTIONS"};
        private string[] OPTIONS = {"BACK"};
        private string[] DISPLAY;
        private bool defaultOpt = false; 
        private const int X_POS = 150;
        private const int Y_POS = 130;
        private const int SPACE = 10; 

        private const float INITIAL_POS = 133f;
        private const float SECONDARY_POS = 143f; 
        private float yPos = 133f;

        private const int SKULL_X = 1;
        private const int SKULL_Y = 74; 

        public Title()
        {
#if DEBUG
            Console.WriteLine("Entered: Title Screen");
#endif
            DISPLAY = MENU; 
            eTime = 0.0f; 
        }

        public override void update(GameTime gameTime) {
            eTime += (float)gameTime.ElapsedGameTime.Milliseconds;
        }

        public override void draw(SpriteBatch spriteBatch)
        {
            // Title
            //rect = new Rectangle(0, 0, 288, 240);
            //spriteBatch.Draw(globals.Title, new Vector2(0f, 0f), rect, color);

            // Header
            // Draw_Header(spriteBatch); 

            // Gameplay Options

            // Skull token
            rect = new Rectangle(SKULL_X, SKULL_Y, Globals.Tiles.Size / 2, Globals.Tiles.Size / 2);
            spriteBatch.Draw(game.TileSet(), new Vector2(95f, yPos), rect, color);

            for (int n = 0; n < DISPLAY.Length; n++)
                Globals.Text.Draw(spriteBatch, game.Font(), DISPLAY[n], X_POS + (20 * n), Y_POS + (10 * n), Globals.Font.Red, SPACE);

        }

        public override void input(KeyboardState state, bool isKeyDown)
        {
            // Enter Key
            if (state.IsKeyDown(Keys.Enter) && !isKeyDown)
            {
                if (yPos == INITIAL_POS)
                    if (defaultOpt)
                        game.setScreen(new Game());
                    //   else
                    //  updateScaling();
                    else
                        defaultOpt = !defaultOpt; 
            }

            if ((state.IsKeyDown(Keys.Up) || state.IsKeyDown(Keys.Down) || 
                state.IsKeyDown(Keys.W) || state.IsKeyDown(Keys.S)) && !isKeyDown)
            {
                if (yPos == INITIAL_POS)
                    yPos = SECONDARY_POS;
                else
                    yPos = INITIAL_POS; 
            }
        }
    }
}
