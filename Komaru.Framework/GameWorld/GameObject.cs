using Komaru.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Komaru.Framework.GameWorld;

// Base class for game object
public class GameObject
{
    public const int SIZE_MOD = 1;
    public Atlas Atlas { get; private set; }
    public int frame { get; protected set; }
    public Texture2D Texture { get; private set; }
    protected Vector2 position;
    protected Vector2 size;

    // Returning gameobject rectangle (for drawing or collisions checking)
    public Rectangle rectangle
    {
        get
        {
            return new Rectangle
            (
                (int)position.X,
                (int)position.Y,
                (int)size.Y * SIZE_MOD,
                (int)size.X * SIZE_MOD
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