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

namespace CutenessOverload
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Define all the variables you want to use here

        Texture2D background;  // This is a Texture2D object that will hold the background picture
        Texture2D superDogSheet;  // What's supdog?
        Sprite superdog;  // We will load a superdog image into this sprite and make him do awesome things!
        Sprite superdog2;
        Sprite superdog3;
        Sprite superdog4;
        Sprite superdog5;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
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

            // TODO: use this.Content to load your game content here
            background = Content.Load<Texture2D>("background");  // Load the background picture file into the 
                                                                 // texture.. note that under the properties for 
                                                                 // background.jpg in the Solution explorer you 
                                                                 // should see that it has the asset name of "background"

            superDogSheet = Content.Load<Texture2D>("superdog");

            superdog = new Sprite(new Vector2(50, 30), // Start at x=-150, y=30
                                  superDogSheet, 
                                  new Rectangle(0, 0, 163, 170), // Use this part of the superdog texture
                                  new Vector2(90, 20));

            superdog2 = new Sprite(new Vector2(90, 20), // Start at x=-150, y=30
                                  superDogSheet,
                                  new Rectangle(167, 0, 163, 170), // Use this part of the superdog texture
                                  new Vector2(70, 40));

            superdog3 = new Sprite(new Vector2(90, 20), // Start at x=-150, y=30
                                 superDogSheet,
                                 new Rectangle(167, 0, 163, 170), // Use this part of the superdog texture
                                 new Vector2(60, 10));

            superdog4 = new Sprite(new Vector2(90, 20), // Start at x=-150, y=30
                                 superDogSheet,
                                 new Rectangle(0, 200, 160
                                 , 383), // Use this part of the superdog texture
                                 new Vector2(90, 90));

            superdog5 = new Sprite(new Vector2(90, 20), // Start at x=-150, y=30
                                 superDogSheet,
                                 new Rectangle(167, 0, 163, 170), // Use this part of the superdog texture
                                 new Vector2(20, 90));
            //WOOOOO pointless text
            // Add any other initialization code here
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
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            superdog.Rotation = superdog.Rotation + 100;
            superdog2.Rotation = superdog2.Rotation + 800;
            superdog3.Rotation = superdog3.Rotation - .01f;
            superdog4.Rotation = superdog4.Rotation + .01f;
            superdog5.Rotation = superdog5.Rotation + 100000;
            if (superdog.Location.X > 800)
                superdog.Location = new Vector2(-100, 100);
            if (superdog2.Location.X > 800)
                superdog2.Location = new Vector2(-100, 100);
            if (superdog3.Location.X > 800)
                superdog3.Location = new Vector2(-100, 100);
            if (superdog4.Location.X > 800)
                superdog4.Location = new Vector2(-100, 100);
            if (superdog5.Location.X > 800)
                superdog5.Location = new Vector2(-100, 100);

            /*
            if (superdog.BoundingBoxRect.Intersects(superdog2.BoundingBoxRect))
            {
                superdog.Velocity *= -1;
            }
            */



            // TODO: Add your update logic here
            superdog.Update(gameTime);  // Update the superdog so he moves
            superdog2.Update(gameTime);
            superdog3.Update(gameTime);
            superdog4.Update(gameTime);
            superdog5.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            // TODO: Add your drawing code here
            spriteBatch.Draw(background, new Rectangle(0,0,this.Window.ClientBounds.Width,this.Window.ClientBounds.Height), Color.White); // Draw the background at (0,0) - no crazy tinting
            superdog.Draw(spriteBatch);  // Draw the superdog!
            superdog2.Draw(spriteBatch);
            superdog3.Draw(spriteBatch);
            superdog4.Draw(spriteBatch);
            superdog5.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
