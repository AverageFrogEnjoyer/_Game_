﻿using _Game_.Entities;
using Game_;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Game_.Managers
{
    public static class InputManager
    {
        private static MouseState lastMouseState;
        //private static KeyboardState _lastKeyboardState;
        private static Vector2 _direction;
        public static Vector2 Direction => _direction;
        public static Vector2 MousePosition => Mouse.GetState().Position.ToVector2();
        public static bool MouseClicked { get; private set; }
        public static bool MouseRightClicked { get; private set; }
        public static bool MouseLeftDown { get; private set; }
        //public static bool SpacePressed { get; private set; }

        public static void Update()
        {
            var keyboardState = Keyboard.GetState();
            var mouseState = Mouse.GetState();

            _direction = Vector2.Zero;
            //if (keyboardState.IsKeyDown(Keys.W)) _direction.Y--;
            //if (keyboardState.IsKeyDown(Keys.S)) _direction.Y++;
            //if (keyboardState.IsKeyDown(Keys.A)) _direction.X--;
            //if (keyboardState.IsKeyDown(Keys.D)) _direction.X++;

            if (!Player.Dead)
            {
                if (keyboardState.IsKeyDown(Keys.Left) ||
                keyboardState.IsKeyDown(Keys.A))
                {
                    Player.ChangePositionAndFrame(1);
                    _direction.X--;
                }
                if (keyboardState.IsKeyDown(Keys.Right) ||
                    keyboardState.IsKeyDown(Keys.D))
                {
                    Player.ChangePositionAndFrame(2);
                    _direction.X++;
                }
                if (keyboardState.IsKeyDown(Keys.Up) ||
                    keyboardState.IsKeyDown(Keys.W))
                {
                    Player.ChangePositionAndFrame(3);
                    _direction.Y--;
                }
                if (keyboardState.IsKeyDown(Keys.Down) ||
                    keyboardState.IsKeyDown(Keys.S))
                {
                    Player.ChangePositionAndFrame(0);
                    _direction.Y++;
                }
            }

            //if (keyboardState.IsKeyDown(Keys.Enter))
            //{
            //    Player.Dead = false;

            //}

            MouseLeftDown = mouseState.LeftButton == ButtonState.Pressed;
            MouseClicked = MouseLeftDown && (lastMouseState.LeftButton == ButtonState.Released);
            MouseRightClicked = mouseState.RightButton == ButtonState.Pressed
                                && (lastMouseState.RightButton == ButtonState.Released);
            lastMouseState = Mouse.GetState();
        }
    }
}
