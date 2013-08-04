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

namespace DEAD.com.blackrose.Screens
{
    public class Title : Screen
    {
        private float yPos = 133f;

        public Title()
        {
            Console.WriteLine("Entered: Title Screen");
            e_Time = 0.0f; 
        }

        public override void update(GameTime gameTime) 
        {
            e_Time += (float)gameTime.ElapsedGameTime.Milliseconds;

            if (e_Time > 2000f) { game.setScreen(new Game()); }
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
            Draw_Text(spriteBatch, "START", 150, 130, globals.Red, 10);
            Draw_Text(spriteBatch, "OPTIONS", 170, 140, globals.Red, 10); 
            
            // Copyright Info
            rect = new Rectangle(69, 52, globals.spriteSize / 2, globals.spriteSize / 2);

            spriteBatch.Draw(globals.tileset, new Vector2(15f, 203f), rect, color); 
            Draw_Text(spriteBatch, "1985 BLACK ROSE FUNERAL HOME", 270, 200, Color.White, 9);
            Draw_Text(spriteBatch, "ALL RIGHTS RESERVED", 224, 210, Color.White, 9);

            // Credits
            Draw_Text(spriteBatch, "CREDIT", 60, 228, globals.LBlue, 10);
            Draw_Text(spriteBatch, "1", 80, 228, globals.OWhite, 10);
        }
    }
}
