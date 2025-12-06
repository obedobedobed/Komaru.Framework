using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Komaru.Framework.SceneManagement;

// Base class for scenes
public abstract class Scene (GraphicsDeviceManager graphicsDevice)
{
    protected GraphicsDeviceManager graphicsDevice = graphicsDevice;

    // Use this method for loading scene content and creating scene objects
    public abstract void Load(ContentManager Content);

    // Use this method to update your scene objects
    public abstract void Update(GameTime gameTime);

    // Use this method to draw your scene objects
    public abstract void Draw(SpriteBatch spriteBatch);
}