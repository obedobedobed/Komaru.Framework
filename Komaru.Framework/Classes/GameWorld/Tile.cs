using Komaru.Framework.Classes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Komaru.Framework.GameWorld;

public class Tile : GameObject
{
    private int tileId;
    private static int tilesCount;
    public int TileNumber { get; private set; }
    private const int GROUND_RECTANGLE_HEIGHT = 5;
    private bool haveCollision;

    public Rectangle intersectionRectangle
    {
        get
        {
            return haveCollision ? new Rectangle
            (
                rectangle.X,
                rectangle.Y + GROUND_RECTANGLE_HEIGHT,
                rectangle.Width,
                rectangle.Height - GROUND_RECTANGLE_HEIGHT
            ) : Rectangle.Empty;
        }
    }

    public Rectangle groundRectangle
    {
        get
        {
            return haveCollision ? new Rectangle
            (
                rectangle.X,
                rectangle.Y - (rectangle.Y - GROUND_RECTANGLE_HEIGHT),
                rectangle.Width,
                GROUND_RECTANGLE_HEIGHT
            ) : Rectangle.Empty;
        }
    }

    public Tile(Texture2D texture, Vector2 position, Vector2 size, bool haveCollision, int tileId)
    : base(texture, position, size)
    {
        this.haveCollision = haveCollision;
        this.tileId = tileId;
        TileNumber = ++tilesCount;
    }

    public static void ClearTilesCount()
    {
        tilesCount = 0;
    }
}