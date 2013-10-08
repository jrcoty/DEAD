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
using Microsoft.Xna.Framework.Input;

using DEAD.com.blackrose.Inputs;
using DEAD.com.blackrose.Main;
using DEAD.com.blackrose.Stages; 

namespace DEAD.com.blackrose.Screens
{
    public class Game : Screen
    {
        private Stage stage;
        private const string STAGE_LAYOUT = "layout_Main"; 

        public Game() 
        {
#if DEBUG   
            Console.WriteLine("Entered: Game Screen"); 
#endif
            eTime = 0.0f; 

            stage = new Stage();
            stage.loadStage(STAGE_LAYOUT); 
        }

        public override void update(GameTime gameTime) {
            eTime += (float)gameTime.ElapsedGameTime.Milliseconds;
        }

        public override void draw(SpriteBatch spriteBatch) {
            stage.Draw(spriteBatch, game.TileSet()); 
        }

        public override void input(KeyboardState state, bool isKeyDown)
        {

        }
    }
}
