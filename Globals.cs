﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace Game_
{
    public static class Globals
    {
        public static float TotalSeconds { get; set; }
        public static ContentManager Content { get; set; }
        public static SpriteBatch SpriteBatch { get; set; }
        public static Point Bounds { get; set; }

        public static void Update(GameTime gt)
        {
            TotalSeconds = (float)gt.ElapsedGameTime.TotalSeconds;
        }
    }
}

