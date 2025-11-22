using Microsoft.Xna.Framework.Content;

namespace Komaru.Framework.Scenes;

public static class SceneManager
{
    public static ContentManager contentManager;
    public static Scene scene { get; private set; }

    // Method for assign content manager
    public static void LoadContentManager(ContentManager contentManager)
    {
        SceneManager.contentManager = contentManager;
    }

    // Method for reassign scene and load it
    public static void LoadScene(Scene scene)
    {
        SceneManager.scene = scene;
        scene.Load(contentManager);
    } 
}
