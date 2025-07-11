using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ZkouskaMaria;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}


Texture2D marioTexture;
Vector2 marioPosition;

protected override void LoadContent()
{
    _spriteBatch = new SpriteBatch(GraphicsDevice);

    int width = 50;    // šířka čtverce
    int height = 50;   // výška čtverce (pro čtverec stejné)

    marioTexture = new Texture2D(GraphicsDevice, width, height);

    Color[] data = new Color[width * height];
    for (int i = 0; i < data.Length; i++)
        data[i] = Color.Red;  // barva čtverce (můžeš změnit třeba na Color.Blue)

    marioTexture.SetData(data);

    marioPosition = new Vector2(100, 100); // pozice na obrazovce
}
