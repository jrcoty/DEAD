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

namespace DEAD.com.blackrose.Screens
{
    public class Title : Screen
    {
        private Boolean dOpt = false; 
        private float yPos = 133f;

        public Title()
        {
            Console.WriteLine("Entered: Title Screen");
            e_Time = 0.0f; 
        }

        public override void update(GameTime gameTime) {
            e_Time += (float)gameTime.ElapsedGameTime.Milliseconds;
        }

        public override void draw(SpriteBatch spriteBatch)
        {
            // Title
            rect = new Rectangle(0, 0, 288, 240);
            spriteBatch.Draw(globals.Title, new Vector2(0f, 0f), rect, color);

            // Header
            Draw_Header(spriteBatch); 

            // Gameplay Options
            rect = new Rectangle(69, 61, globals.spriteSize / 2, globals.spriteSize / 2);
            spriteBatch.Draw(globals.tileset, new Vector2(95f, yPos), rect, color);
            
            if (!dOpt)
            {
                Draw_Text(spriteBatch, "START", 150, 130, globals.Red, 10);
                Draw_Text(spriteBatch, "OPTIONS", 170, 140, globals.Red, 10);
            }
            else
            {
                Draw_Text(spriteBatch, "SCREEN: " + globals.ScreenWidth.ToString() + "x" + globals.ScreenHeight.ToString(), 250, 130, globals.Red, 10);
                Draw_Text(spriteBatch, "BACK", 140, 140, globals.Red, 10);
            }

            // Copyright Info
            rect = new Rectangle(69, 52, globals.spriteSize / 2, globals.spriteSize / 2);

            spriteBatch.Draw(globals.tileset, new Vector2(15f, 203f), rect, color); 
            Draw_Text(spriteBatch, "1985 BLACK ROSE FUNERAL HOME", 270, 200, Color.White, 9);
            Draw_Text(spriteBatch, "ALL RIGHTS RESERVED", 224, 210, Color.White, 9);

            // Credits
            Draw_Text(spriteBatch, "CREDIT", 60, 228, globals.LBlue, 10);
            Draw_Text(spriteBatch, "1", 80, 228, globals.OWhite, 10);
        }

        public override void input(KeyboardState state)
        {
            // Enter Key
            if (state.IsKeyDown(Keys.Enter) && !globals.isKeyDown)
            {
                if (yPos == 133f)
                    if (!dOpt)
                        game.setScreen(new Game());
                    else
                        updateScaling();
                else
                    if (!dOpt)
                        dOpt = true;
                    else
                        dOpt = false;
            }

            // Down Key
            if ((state.IsKeyDown(Keys.Up) || state.IsKeyDown(Keys.Down) || 
                state.IsKeyDown(Keys.W) || state.IsKeyDown(Keys.S)) && !globals.isKeyDown)
            {
                if (yPos == 133f)
                    yPos = 143f;
                else
                    yPos = 133f; 
            }
        }

        private void updateScaling()
        {
            if (globals.ScreenRegular)
            {
                globals.ScreenWidth = globals.ScreenWidth / globals.sFactor;
                globals.ScreenHeight = globals.ScreenHeight / globals.sFactor;

                globals.xScale = globals.xScale / globals.sFactor;
                globals.yScale = globals.yScale / globals.sFactor;

                globals.ScreenRegular = false; 
            }
            else
            {
                globals.ScreenWidth = globals.ScreenWidth * globals.sFactor;
                globals.ScreenHeight = globals.ScreenHeight * globals.sFactor;

                globals.xScale = globals.xScale * globals.sFactor;
                globals.yScale = globals.yScale * globals.sFactor;

                globals.ScreenRegular = true; 
            }

            game.applyChanges(); 
        }

    }
}
