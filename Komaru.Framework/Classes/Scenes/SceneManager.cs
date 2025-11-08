using Microsoft.Xna.Framework.Content;

namespace Komaru.Framework.Scenes;

public class SceneManager
{
    public Scene currentScene { get; private set; }

    // Method for reassign currentScene and load it
    public void LoadScene(Scene scene, ContentManager contentManager)
    {
        currentScene = scene;
        currentScene.Load(contentManager);
    } 
}
