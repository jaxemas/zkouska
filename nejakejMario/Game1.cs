using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SimpleMario
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D marioTexture;
        Vector2 marioPosition;
        Vector2 velocity;

        bool isJumping = false;

        float gravity = 800f; // gravitace (pixely za sekundu^2)
        float jumpSpeed = -400f; // počáteční rychlost skoku (nahoru je záporná)
        float moveSpeed = 200f; // rychlost pohybu (pixely za sekundu)

        int groundLevel;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 480;
        }

        protected override void Initialize()
        {
            groundLevel = graphics.PreferredBackBufferHeight - 50;
            marioPosition = new Vector2(100, groundLevel);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Vytvoření červeného čtverečku jako Mario
            marioTexture = new Texture2D(GraphicsDevice, 40, 50);
            Color[] data = new Color[40 * 50];
            for (int i = 0; i < data.Length; i++)
                data[i] = Color.Red;
            marioTexture.SetData(data);
        }

        protected override void Update(GameTime gameTime)
        {
            float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            KeyboardState ks = Keyboard.GetState();

            // Pohyb doleva a doprava
            if (ks.IsKeyDown(Keys.Left))
                marioPosition.X -= moveSpeed * delta;
            if (ks.IsKeyDown(Keys.Right))
                marioPosition.X += moveSpeed * delta;

            // Skok, pokud není ve vzduchu
            if (ks.IsKeyDown(Keys.Space) && !isJumping)
            {
                velocity.Y = jumpSpeed;
                isJumping = true;
            }

            // Gravitační efekt
            velocity.Y += gravity * delta;
            marioPosition += velocity * delta;

            // Podlaha - zastaví pád a skok
            if (marioPosition.Y >= groundLevel)
            {
                marioPosition.Y = groundLevel;
                velocity.Y = 0;
                isJumping = false;
            }

            // Omezení pohybu, aby Mario nevylezl z obrazovky
            if (marioPosition.X < 0) marioPosition.X = 0;
            if (marioPosition.X > graphics.PreferredBackBufferWidth - marioTexture.Width)
                marioPosition.X = graphics.PreferredBackBufferWidth - marioTexture.Width;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(marioTexture, marioPosition, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
