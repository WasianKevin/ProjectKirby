using System;
using System.Numerics;
using Raylib_cs;

// public class Kirby
// {
//     Rectangle rect = new Rectangle();

//     Texture2D image;

//     public void Update()
//     {
//         rect.X++;
//     }

//     public void Draw()
//     {
//         Raylib.DrawTexture(image, (int)rect.X, (int)rect.Y);
//     }
// }

public class game
{
    static float velocity = 0;

    public static (string, int, Rectangle) kirbygame(string room, int coins, Texture2D KibyMap1, Texture2D Kirby, Rectangle playerRect)
    {

        float speed = 4f;
        float gravity = 3;
        bool isGrounded = false;

        //Allows me to draw a room
        Raylib.BeginDrawing();

        //Draws the background
        Raylib.DrawTexture(KibyMap1, 0, 0, Color.WHITE);

        //Kirby
        Raylib.DrawTexture(Kirby, (int)playerRect.x, (int)playerRect.y, Color.WHITE);
        
        //movement
        (speed, velocity, playerRect, isGrounded) = Movement.move(speed, playerRect, velocity, gravity, Kirby, isGrounded);

        //Ends the drawing
        Raylib.EndDrawing();

        return (room, coins, playerRect);


    }

}