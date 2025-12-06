using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Komaru.Framework.UI;

public class Text
{
    private string content;
    private Vector2 position;
    public Vector2 size { get; private set; }
    private Color color;
    public static SpriteFont Font;

    public Text(string content, Vector2 position, Color color)
    {
        this.content = content;
        this.position = position;
        this.color = color;
        size = Font.MeasureString(content);
    }

    public void Edit(string content)
    {
        this.content = content;
        size = Font.MeasureString(content);
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.DrawString(Font, content, position, color);
    }
}