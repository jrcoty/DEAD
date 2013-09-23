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
        private const int X_POS = 150;
        private const int Y_POS = 130;
        private const int SPACE = 10; 

        private const float INITIAL_POS = 133f;
        private const float SECONDARY_POS = 143f; 
        private float yPos = 133f; 

        private Boolean dOpt = false; 
        
        public Title()
        {
#if DEBUG
            Console.WriteLine("Entered: Title Screen");
#endif
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
            rect = new Rectangle(69, 61, Globals.Tiles.Size / 2, Globals.Tiles.Size / 2);
            spriteBatch.Draw(game.TileSet(), new Vector2(95f, yPos), rect, color);

            for (int n = 0; n < DISPLAY.Length; n++)
                Globals.Text.Draw(spriteBatch, game.Font(), DISPLAY[n], X_POS, Y_POS + (20 * n), Globals.Font.Red, SPACE);

               // Draw_Text(spriteBatch, "START", 150, 130, globals.Red, 10);
                //Draw_Text(spriteBatch, "OPTIONS", 170, 140, globals.Red, 10);
            
               // Draw_Text(spriteBatch, "SCREEN: " + globals.ScreenWidth.ToString() + "x" + globals.ScreenHeight.ToString(), 250, 130, globals.Red, 10);
               // Draw_Text(spriteBatch, "BACK", 140, 140, globals.Red, 10);
           
            // Copyright Info
            // rect = new Rectangle(1, 69, Globals.Tiles.Size / 2, Globals.Tiles.Size / 2);

            // spriteBatch.Draw(game.TileSet(), new Vector2(15f, 203f), rect, color); 
           // Draw_Text(spriteBatch, "1985 BLACK ROSE FUNERAL HOME", 270, 200, Color.White, 9);
            //Draw_Text(spriteBatch, "ALL RIGHTS RESERVED", 224, 210, Color.White, 9);

            // Credits
           // Draw_Text(spriteBatch, "CREDIT", 60, 228, globals.LBlue, 10);
            //Draw_Text(spriteBatch, "1", 80, 228, globals.OWhite, 10);
        }

        public override void input(KeyboardState state, bool isKeyDown)
        {
            // Enter Key
            if (state.IsKeyDown(Keys.Enter) && !isKeyDown)
            {
                if (yPos == INITIAL_POS)
                    if (!dOpt)
                        game.setScreen(new Game());
                 /*   else
                       //  updateScaling();
                else
                    if (!dOpt)
                        dOpt = true;
                    else
                        dOpt = false; */
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
