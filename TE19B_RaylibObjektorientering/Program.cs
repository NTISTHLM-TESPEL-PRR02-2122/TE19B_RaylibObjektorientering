using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "Test");
Raylib.SetTargetFPS(60);

// Rectangle rect = new Rectangle(100, 50, 32, 32);

Avatar micke = new Avatar();

while ( !Raylib.WindowShouldClose() )
{
  micke.Update();

  Raylib.BeginDrawing();
  Raylib.ClearBackground(Color.PINK);

  // Raylib.DrawRectangle(100, 50, 32, 32, Color.ORANGE);

  micke.Draw();

  // Raylib.DrawRectangleRec(rect, Color.BROWN);

  Raylib.EndDrawing();
}