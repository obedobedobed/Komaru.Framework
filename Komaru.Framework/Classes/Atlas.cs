using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Komaru.Framework.Classes;

public class Atlas
{
    public Texture2D AtlasTexture { get; private set; }
    private List<Rectangle> atlasRectanglesList = new List<Rectangle>();
    public Rectangle[] AtlasRectangles
    {
        get
        {
            return atlasRectanglesList.ToArray();
        }
    }

    public Atlas(Texture2D atlasTexture, Vector2 spriteSize)
    {
        AtlasTexture = atlasTexture;

        // Getting atlas rectangles by sprite size and atlas texture

        for (int y = 0; y < atlasTexture.Height; y += (int)spriteSize.Y)
        {
            for (int x = 0; x < atlasTexture.Width; x += (int)spriteSize.X)
            {
                atlasRectanglesList.Add(new Rectangle(y, x, (int)spriteSize.Y, (int)spriteSize.X));
            }
        }
    }
}
