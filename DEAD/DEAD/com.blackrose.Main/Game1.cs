// Jonathan Coty
// 3-Aug-2013
// Black Rose Funeral Home

// Among the DEAD

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using DEAD.com.blackrose.Screens;
using DEAD.com.blackrose.Inputs; 

namespace DEAD.com.blackrose.Main
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private Input keyboard; 

        private Screen screen;
        private Texture2D tileset, title, background;
        private SpriteFont font; 

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = Globals.Screen.Width;
            graphics.PreferredBackBufferHeight = Globals.Screen.Height;  

            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize() {
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            font = Content.Load<SpriteFont>(Globals.Font.Name);

            tileset = Content.Load<Texture2D>(Globals.Tiles.Asset_Tiles);
            title = Content.Load<Texture2D>(Globals.Tiles.Asset_Title);

            keyboard = new Input(); 

            setScreen(new Load()); 
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent() {
            
        }

        public void setScreen(Screen screen)
        {
            this.screen = screen;
            if (screen != null) { screen.init(this); }
        }

        public Texture2D TileSet()
        {
            return tileset; 
        }

        public SpriteFont Font()
        {
            return font; 
        }

        //public void applyChanges() 
        //{
        //    graphics.PreferredBackBufferWidth = Globals.Screen.Width;
        //    graphics.PreferredBackBufferHeight = Globals.Screen.Height;

        //    graphics.ApplyChanges(); 
        //}

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // keyControl.key_press(screen); 
            //screen.input(Keyboard.GetState());
            keyboard.keyPress(screen); 

            screen.update(gameTime);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.Default, RasterizerState.CullCounterClockwise, null, Matrix.CreateScale(globals.xScale, globals.yScale, globals.zScale));

            screen.draw(spriteBatch);

            spriteBatch.End(); 

            base.Draw(gameTime);
        }
    }
}
