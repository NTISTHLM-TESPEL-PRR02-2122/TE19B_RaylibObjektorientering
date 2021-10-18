using System;
using Raylib_cs;

public class Avatar
{
  Rectangle rect = new Rectangle(0, 0, 32, 32);

  Color myColor = Color.RED;

  public void Draw()
  {
    Raylib.DrawRectangleRec(rect, myColor);
  }

  public void Update()
  {
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
      rect.x += 5;
    }
  }
}