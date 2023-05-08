using System;
using Raylib_cs;
using System.Numerics;

public class Movement
{


    public static (float, float, Rectangle, bool) move(float speed, Rectangle playerRect, float velocity, float gravity, Texture2D Kirby, bool isGrounded)
    {

        //Movement
        static Vector2 ReadMovement(float speed)
        {
            Vector2 movement = new Vector2();
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) movement.X += speed;
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) movement.X -= speed;

            return movement;
        }




        //Changing direction of Kirby depending on what way he's walking
        Vector2 movement = ReadMovement(speed);
        playerRect.x += movement.X;
        playerRect.y += movement.Y;

        if (playerRect.x >= 1100)
        {
            playerRect.x = 1100;
            Raylib.DrawText("You cannot walk outside", 150, 200, 50, Color.BLACK);
            Raylib.DrawText("the border of the game!", 150, 275, 50, Color.BLACK);
        }

        if (playerRect.x <= 100)
        {
            playerRect.x = 100;
            Raylib.DrawText("You cannot walk outside", 150, 200, 50, Color.BLACK);
            Raylib.DrawText("the border of the game!", 150, 275, 50, Color.BLACK);
        }

        //if Kirby hits the floor he stops falling
        velocity += gravity;
        if (playerRect.y >= 600 - playerRect.height)
        {
            velocity = 0;
            isGrounded = true;
            playerRect.y = 600 - playerRect.height;
        }

        else
        {
            isGrounded = false;
        }

        //If Kirby leaves the ground he falls down
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE) && isGrounded)
        {
            velocity = -20;
        }

        playerRect.y += velocity;

        return (speed, velocity, playerRect, isGrounded);
    }
}
