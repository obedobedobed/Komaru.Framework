using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Komaru.Framework.SceneManagement;

public static class SceneManager
{
    public static ContentManager contentManager;
    public static Scene scene { get; private set; }

    // Method for assign content manager
    public static void Setup(ContentManager contentManager)
    {
        SceneManager.contentManager = contentManager;
    }

    // Method for reassign scene and load it
    public static void LoadScene(Scene scene)
    {
        SceneManager.scene = scene;
        scene.Load(contentManager);
    } 

    // Scene methods
    public static void UpdateScene(GameTime gameTime)
    {
        scene.Update(gameTime);
    }

    public static void Draw(SpriteBatch spriteBatch)
    {
        scene.Draw(spriteBatch);
    }
}
