using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace InteractiveKeyboard2010.Input
{
    public static class Input
    {
        private static MouseState oldState;
        private static MouseState newState;
        public static Vector2 Position { get; set; }
        public static void Update()
        {
            oldState = newState;
            newState = Mouse.GetState();
            Position = new Vector2(newState.X,newState.Y);
        }

        public static bool IsLeftClick()
        {
            return newState.LeftButton == ButtonState.Released && oldState.LeftButton == ButtonState.Pressed;
        }
        

    }
}
