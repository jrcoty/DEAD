// Jonathan Coty
// 3-Aug-2013
// Black Rose Funeral Home

// Displays the game

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

using DEAD.com.blackrose.Stages; 

namespace DEAD.com.blackrose.Screens
{
    public class Game : Screen
    {
        private Stage stage;

        public Game() 
        {
            Console.WriteLine("Entered: Game Screen");
            e_Time = 0.0f; 

            stage = new Stage(); 
        }

        public override void update(GameTime gameTime) {
            e_Time += (float)gameTime.ElapsedGameTime.Milliseconds;
        }

        public override void draw(SpriteBatch spriteBatch) {
            stage.Draw(spriteBatch); 
        }
    }
}
