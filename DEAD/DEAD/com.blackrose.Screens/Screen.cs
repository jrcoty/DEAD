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

using DEAD.com.blackrose.Inputs;
using DEAD.com.blackrose.Main;

namespace DEAD.com.blackrose.Screens
{
    public class Screen
    {
        protected float eTime; 
        protected Vector2 vector;
        protected Rectangle rect;
        protected Color color = Color.White;

        protected Game1 game;

        public void init(Game1 game) {
            this.game = game;
        }

        public virtual void update(GameTime gameTime) {

        }

        public virtual void draw(SpriteBatch spriteBatch) {

        }

        public virtual void input(KeyboardState state, bool isKeyDown) {
        
        }
    }
}
