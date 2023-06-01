using System;
using System.Numerics;
using Raylib_cs;

public class kirby
{
    public int hp;
    public string name;
    public int size = 10;
    public Texture2D Kirby = Raylib.LoadTexture("Kirby.png");
    public float speed = 4f;
    public float gravity = 3;
    public bool isGrounded = false;
    public float velocity = 0;
    public Rectangle playerRect;


    public kirby()
    {
        playerRect = new Rectangle(160, 600, Kirby.width, Kirby.height);
    }


    //Movement
    public Vector2 ReadMovement(float speed)
    {
        Vector2 movement = new Vector2();
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D)) movement.X += speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A)) movement.X -= speed;

        return movement;
    }

    public void Update(List<Rectangle> walls)
    {


        //way kirby facing
        Vector2 movement = ReadMovement(speed);
        playerRect.x += movement.X;
        playerRect.y += movement.Y;

        bool undoX = false;

        //If I walk into a wall X, checks collision
        foreach (Rectangle wall in walls)
        {
            if (Raylib.CheckCollisionRecs(playerRect, wall) == true)
            {
                undoX = true;
            }
        }

        if (undoX) playerRect.x -= movement.X;
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

        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ESCAPE)) System.Environment.Exit(1);

        if (playerRect.x >= 1100)
        {
            Raylib.DrawText("You cannot walk outside", 150, 200, 50, Color.BLACK);
            Raylib.DrawText("the border of the game!", 150, 275, 50, Color.BLACK);
        }

        if (playerRect.x <= 100)
        {
            Raylib.DrawText("You cannot walk outside", 150, 200, 50, Color.BLACK);
            Raylib.DrawText("the border of the game!", 150, 275, 50, Color.BLACK);
        }
        
    }


}

