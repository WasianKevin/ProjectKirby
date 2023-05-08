using System;
using Raylib_cs;

public class StartScreen
{


    public static (string, Texture2D) MainMenu(Texture2D main, string room)
    {

        //Allows me to draw a room
        Raylib.BeginDrawing();

        //Draws the background
        Raylib.DrawTexture(main, 0, 0, Color.WHITE);

        //If i press enter, u switch room
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)) room = "game";

        //Text "Press ENTER to enter
        Raylib.DrawText("Press ENTER to enter the game.", 198, 598, 50, Color.WHITE);
        Raylib.DrawText("Press ENTER to enter the game.", 203, 603, 50, Color.BLACK);
        Raylib.DrawText("Press ENTER to enter the game.", 200, 600, 50, Color.GOLD);

        //Ends the drawing
        Raylib.EndDrawing();

        return (room, main);
    }
}
