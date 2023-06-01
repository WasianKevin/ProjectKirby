using System;
using System.Numerics;
using Raylib_cs;
public class CurrentRoom
{

    public static string room;
    public static int coins = 0;

    public static Texture2D main = Raylib.LoadTexture("Kiby.png");
    public static Texture2D KibyMap1 = Raylib.LoadTexture("KibyMap1.png");
    public static Texture2D KibyMap2 = Raylib.LoadTexture("KibyMap2.png");

    public kirby k = new kirby();








    public void MainMenu()
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
    }








    public void kirbygame()
    {
        List<Rectangle> Walls = new List<Rectangle>();
        Walls.Add(new Rectangle(90, 10, 10, 1000));
        Walls.Add(new Rectangle(1160, 10, 10, 1000));


        k.Update(Walls);

        //Allows me to draw a room
        Raylib.BeginDrawing();

        //Draws the background
        Raylib.DrawTexture(KibyMap1, 0, 0, Color.WHITE);

        Raylib.DrawTexture(k.Kirby, (int)k.playerRect.x, (int)k.playerRect.y, Color.WHITE);

        Raylib.DrawText("Press ESCAPE to quit the game!", 10, 10, 30, Color.RED);

        //Ends the drawing
        Raylib.EndDrawing();

    }


}
