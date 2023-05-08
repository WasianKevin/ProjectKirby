using System;
using System.Numerics;
using Raylib_cs;


//Gör en skärm och väljer FPS
Raylib.InitWindow(1200, 700, "Project: Kirby");
Raylib.SetTargetFPS(60);


//Strings, Bools etc.
string room = "menu";
int coins = 0;

// Kirby k = new Kirby();


//Alla bilder i spelet
Texture2D main = Raylib.LoadTexture("Kiby.png");
Texture2D KibyMap1 = Raylib.LoadTexture("KibyMap1.png");
Texture2D KibyMap2 = Raylib.LoadTexture("KibyMap2.png");

Texture2D Kirby = Raylib.LoadTexture("Kirby.png");

Rectangle playerRect = new Rectangle(60, 600, Kirby.width, Kirby.height);

while (!Raylib.WindowShouldClose())
{
    // k.Update();

    //Start Screen
    if (room == "menu") (room, main) = StartScreen.MainMenu(main, room);
    // k.Draw();
    //Game
    if (room == "game") (room, coins, playerRect) = game.kirbygame(room, coins, KibyMap1, Kirby, playerRect);

}