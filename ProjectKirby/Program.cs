using System;
using System.Numerics;
using Raylib_cs;


//Gör en skärm och väljer FPS
Raylib.InitWindow(1200, 700, "Project: Kirby");
Raylib.SetTargetFPS(60);

CurrentRoom.room = "menu";

CurrentRoom r1 = new CurrentRoom();

while (!Raylib.WindowShouldClose())
{
    //Start Screen
    if (CurrentRoom.room == "menu") r1.MainMenu();
    //Game
    if (CurrentRoom.room == "game") r1.kirbygame();

}