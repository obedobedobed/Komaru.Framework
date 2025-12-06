using Komaru.Framework.GameWorld;
using Komaru.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Komaru.Framework.UI;

// Base class for buttons
public abstract class Button : GameObject
{
    protected bool canBePressed = false;

    public Button(Atlas atlas, Vector2 position, Vector2 size, int defaultFrame = 0)
    : base(atlas, position, size, defaultFrame) { }

    // Updating button
    public virtual void Update()
    {
        // Getting cursor
        var mouseState = Mouse.GetState();
        var cursor = new Rectangle(mouseState.X, mouseState.Y, 1, 1);

        // Checking for cursor on button
        canBePressed = cursor.Intersects(rectangle);

        // Checking for button pressed
        if (mouseState.LeftButton == ButtonState.Pressed && canBePressed)
        {
            OnClick();
        }
    }

    // Button on click logic
    protected abstract void OnClick();
}