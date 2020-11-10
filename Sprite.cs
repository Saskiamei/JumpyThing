﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpyThing
{
    class Sprite
    {
        public Texture2D spriteSheetTxr, collisionTxr;
        public Vector2 spriteLocation, spriteVelocity, spriteOffset, collisionScale, CollisionOffset;
        public bool isDead, isColliding, drawCollision, isFlipped;

        public int currentAnim, currentFrame;
        public float frameTime, frameCounter;
        public List<List<Rectangle>> animations;


        public Sprite(Texture2D newSpriteSheet, Texture2D newCollisionTxr, Vector2 newLocation)
        {
            spriteSheetTxr = newSpriteSheet;
            collisionTxr = newCollisionTxr;
            spriteLocation = newLocation;

            spriteOffset = new Vector2(0.5f, 0.5f);
            spriteVelocity = new Vector2(0f, 0f);
            collisionScale = new Vector2(1f, 1f);
            CollisionOffset = new Vector2(0f, 0f);
            isColliding = false;
            drawCollision = false;
            isDead = false;
            currentAnim = 0;
            currentFrame = 0;
            frameTime = 0.5f;
            frameCounter = frameTime;

            animations = new List<List<Rectangle>>();

            animations.Add(new List<Rectangle>());
            animations[0].Add(new Rectangle(0, 0, 40, 48));
        }

        public virtual void Update(GameTime gameTime, Point screenSize) { }

    }
}