#region Using Statements
using System;
using System.Collections.Generic;
using InteractiveKeyboard2010.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Input.Touch;

using EyeTrackingKeyBoard.Board;
#endregion

namespace EyeTrackingKeyBoard
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class InteractiveKeyboard : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D rect = null;
        GazePoint gazePoint;
        Color bgColor = new Color(207,216,220);
        int width = 2160;
        int height = 1440;

        public InteractiveKeyboard()
            : base()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            gazePoint = new GazePoint();
            graphics.PreferredBackBufferHeight = height;
            graphics.PreferredBackBufferWidth = width;
            graphics.IsFullScreen = true;
            this.IsMouseVisible = true;
            Static.graphics = graphics;
            
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            Static.SpriteBatch = spriteBatch;
            Static.SpriteFont = Content.Load<SpriteFont>("SpriteFont1");
             rect = new Texture2D(graphics.GraphicsDevice, 1, 1);
            rect.SetData(new[] { Color.White });
            var mainStage = new MainBoard(width, height);
            Static.CurrentStage = mainStage;
            Static.MainStage = mainStage;
            Static.Text = "";

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            Input.Update();
            Static.CurrentStage.Update(gameTime);
           
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(bgColor);

            spriteBatch.Begin();
            
            Static.CurrentStage.Draw(gameTime);
            spriteBatch.DrawString(Static.SpriteFont, Static.Text, new Vector2(width/3f, height/2.8f), Color.Black);
           // spriteBatch.Draw(rect, new Rectangle((int)gazePoint.X, (int)gazePoint.Y, 20, 20), Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
