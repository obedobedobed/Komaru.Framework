using Komaru.Framework.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Komaru.Framework.Classes.UI;

// Changing scene when pressed
public class SceneButton : Button
{
    private SceneManager sceneManager;
    private Scene scene;
    private ContentManager contentManager;

    public SceneButton(Atlas atlas, Vector2 position, Vector2 size, SceneManager sceneManager,
    Scene scene, ContentManager contentManager, int frame = 0) : base(atlas, position, size, frame)
    {
        this.sceneManager = sceneManager;
        this.scene = scene;
        this.contentManager = contentManager;
    }

    protected override void OnClick()
    {
        sceneManager.LoadScene(scene, contentManager);
    }
}