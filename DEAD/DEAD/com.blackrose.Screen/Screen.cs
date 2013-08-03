﻿// Jonathan Coty
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

namespace DEAD.com.blackrose.Screen
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

        protected void Draw_Header(SpriteBatch spriteBatch)
        {
            /*Draw_Text(spriteBatch, "PLAYER 1", 80, 0, globals.Gold, 10);
            Draw_Text(spriteBatch, globals.P_SCore.ToString(), 80, 10, global_vars.L_Blue, 10);

            Draw_Text(spriteBatch, "TOP SCORE", 180, 0, global_vars.L_Red, 10);
            Draw_Text(spriteBatch, global_vars.H_SCore.ToString(), 180, 10, global_vars.O_White, 10); */
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
