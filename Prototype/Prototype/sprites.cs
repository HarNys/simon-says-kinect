﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Sprits
{
    // Animation representing the player
    public Texture2D imgTexture;

    // Position of the Player relative to the upper left side of the screen
    public Vector2 Position;

    // State of the player
    public bool Active;

    // Amount of hit points that player has
    public int Health;

    // Get the width of the player ship
    public int Width
    {
        get { return imgTexture.Width; }
    }

    // Get the height of the player ship
    public int Height
    {
        get { return imgTexture.Height; }
    }


    public void Initialize(Texture2D texture, Vector2 position)
    {
        imgTexture = texture;

        Position = position;

        Active = true;
    }

    public void Update()
    {
        
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(imgTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
    }
}