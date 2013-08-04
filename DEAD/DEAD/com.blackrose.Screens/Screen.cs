// Jonathan Coty
// 3-Aug-2013
// Black Rose Funeral Home

// Screen template class

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
    public class Screen
    {
        protected float e_Time; 
        protected Vector2 vector;
        protected Rectangle rect;
        protected Color color = Color.White;

        protected Game1 game;

        private int idx, tmpX; 

        public void init(Game1 game) {
            this.game = game; 
        }

        public virtual void update(GameTime gameTime) {

        }

        public virtual void draw(SpriteBatch spriteBatch) {

        }

        public virtual void input(KeyboardState state) {
        
        }

        protected void Draw_Header(SpriteBatch spriteBatch)
        {
            Draw_Text(spriteBatch, "PLAYER 1", 80, 0, globals.Gold, 10);
            Draw_Text(spriteBatch, "0", 80, 10, globals.LBlue, 10);

            Draw_Text(spriteBatch, "TOP SCORE", 180, 0, globals.LRed, 10);
            Draw_Text(spriteBatch, "10000", 180, 10, globals.OWhite, 10); 
        }

        protected void Draw_Text(SpriteBatch spriteBatch, string str, int xPos, int yPos, Color color, int space)
        {
            for (idx = str.Length; idx > 0; idx--)
            {
                tmpX = xPos - ((str.Length - idx) * space);

                spriteBatch.DrawString(globals.Font, str[idx - 1].ToString(), new Vector2(tmpX, yPos), color);
            }
        }
    }
}
