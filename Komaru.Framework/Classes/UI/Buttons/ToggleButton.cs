using Komaru.Framework.Classes;
using Microsoft.Xna.Framework;

namespace Komaru.Framework.UI;

// Toggling state when pressed
public abstract class ToggleButton : Button
{
    private bool isPressed;

    // Frames
    private int pressedFrame;
    private int unpressedFrame;

    public ToggleButton(Atlas atlas, Vector2 position, Vector2 size, int pressedFrame, int unpressedFrame,
    int defaultFrame = 0, bool isPressedDefault = false) : base(atlas, position, size, defaultFrame)
    {
        isPressed = isPressedDefault;
        this.pressedFrame = pressedFrame;
        this.unpressedFrame = unpressedFrame;
    }

    // Button on click logic
    protected override void OnClick()
    {
        isPressed = !isPressed;
        frame = isPressed ? pressedFrame : unpressedFrame;
    }
}