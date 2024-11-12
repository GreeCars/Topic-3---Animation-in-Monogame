using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_3___Animation_in_Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Rectangle window;

        Texture2D greyTribbleTexture;
        Rectangle greyTribbleRect;
        Vector2 greyTribbleSpeed;

        Texture2D orangeTribbleTexture;
        Rectangle orangeTribbleRect;
        Vector2 orangeTribbleSpeed;

        Texture2D brownTribbleTexture;
        Rectangle brownTribbleRect;
        Vector2 brownTribbleSpeed;

        Texture2D creamTribbleTexture;
        Rectangle creamTribbleRect;
        Vector2 creamTribbleSpeed;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            greyTribbleRect = new Rectangle(300, 10, 100, 100);
            greyTribbleSpeed = new Vector2(2, 2);

            orangeTribbleRect = new Rectangle(300, 110, 100, 100);
            orangeTribbleSpeed = new Vector2(3, 3);

            brownTribbleRect = new Rectangle(300, 210, 100, 100);
            brownTribbleSpeed = new Vector2(4, 4);

            creamTribbleRect = new Rectangle(300, 310, 100, 100);
            creamTribbleSpeed = new Vector2(5, 5);

            window = new Rectangle(0, 0, 800, 600);
            _graphics.PreferredBackBufferWidth = window.Width;
            _graphics.PreferredBackBufferHeight = window.Height;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            greyTribbleTexture = Content.Load<Texture2D>("tribbleGrey");
            orangeTribbleTexture = Content.Load<Texture2D>("tribbleOrange");
            brownTribbleTexture = Content.Load<Texture2D>("tribbleBrown");
            creamTribbleTexture = Content.Load<Texture2D>("tribbleCream");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            greyTribbleRect.X += (int)greyTribbleSpeed.X;
            if (greyTribbleRect.Right > window.Width || greyTribbleRect.Left < 0)
                greyTribbleSpeed.X *= -1;
            greyTribbleRect.Y += (int)greyTribbleSpeed.Y;
            if (greyTribbleRect.Bottom > window.Height || greyTribbleRect.Top < 0)
                greyTribbleSpeed.Y *= -1;

            orangeTribbleRect.X += (int)orangeTribbleSpeed.X;
            if (orangeTribbleRect.Right > window.Width || orangeTribbleRect.Left < 0)
                orangeTribbleSpeed.X *= -1;
            orangeTribbleRect.Y += (int)orangeTribbleSpeed.Y;
            if (orangeTribbleRect.Bottom > window.Height || orangeTribbleRect.Top < 0)
                orangeTribbleSpeed.Y *= -1;

            brownTribbleRect.X += (int)brownTribbleSpeed.X;
            if (brownTribbleRect.Right > window.Width || brownTribbleRect.Left < 0)
                brownTribbleSpeed.X *= -1;
            brownTribbleRect.Y += (int)brownTribbleSpeed.Y;
            if (brownTribbleRect.Bottom > window.Height || brownTribbleRect.Top < 0)
                brownTribbleSpeed.Y *= -1;

            creamTribbleRect.X += (int)creamTribbleSpeed.X;
            if (creamTribbleRect.Right > window.Width || creamTribbleRect.Left < 0)
                creamTribbleSpeed.X *= -1;
            creamTribbleRect.Y += (int)creamTribbleSpeed.Y;
            if (creamTribbleRect.Bottom > window.Height || creamTribbleRect.Top < 0)
                creamTribbleSpeed.Y *= -1;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(greyTribbleTexture, greyTribbleRect, Color.White);
            _spriteBatch.Draw(orangeTribbleTexture, orangeTribbleRect, Color.White);
            _spriteBatch.Draw(brownTribbleTexture, brownTribbleRect, Color.White);
            _spriteBatch.Draw(creamTribbleTexture, creamTribbleRect, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
