using Komaru.Framework.Classes;
using Komaru.Framework.Scenes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace Komaru.Framework.UI;

// Changing scene when pressed
public class SceneButton : Button
{
    private Scene scene;
    private ContentManager contentManager;

    public SceneButton(Atlas atlas, Vector2 position, Vector2 size,
    Scene scene, ContentManager contentManager, int frame = 0) : base(atlas, position, size, frame)
    {
        this.scene = scene;
        this.contentManager = contentManager;
    }

    protected override void OnClick()
    {
        SceneManager.LoadScene(scene, contentManager);
    }
}