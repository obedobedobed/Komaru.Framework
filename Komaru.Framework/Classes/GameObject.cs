using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Komaru.Framework.Classes;

// Base class for game object
public class GameObject
{
    public Atlas Atlas { get; private set; }
    public int frame { get; protected set; }
    public Texture2D Texture { get; private set; }
    private Vector2 position;
    private Vector2 size;

    // Returning gameobject rectangle (for drawing or collisions checking)
    public Rectangle rectangle
    {
        get
        {
            return new Rectangle
            (
                (int)position.X,
                (int)position.Y,
                (int)size.X * Constants.SIZE_MOD,
                (int)size.Y * Constants.SIZE_MOD
            );
        }
    }

    // Overload for objects with textures atlas
    public GameObject(Atlas atlas, Vector2 position, Vector2 size, int defaultFrame = 0)
    {
        Atlas = atlas;
        this.position = position;
        this.size = size;
        frame = defaultFrame;
    }

    // Overload for objects with one texture
    public GameObject(Texture2D texture, Vector2 position, Vector2 size)
    {
        Texture = texture;
        this.position = position;
        this.size = size;
    }
}