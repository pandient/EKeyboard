using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EyeTrackingKeyBoard.Board;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace EyeTrackingKeyBoard
{
    public static class Static
    {
        public static SpriteBatch SpriteBatch { get; set; }
        public static SpriteFont SpriteFont { get; set; }
        public static SpriteFont BigSpriteFont { get; set; }
        public static Game Game {get; set;}
        public static Stage CurrentStage { get; set; }
        public static GraphicsDeviceManager graphics { get; set; }
        public static MainBoard MainStage { get; set; }
        public static String Text { get; set; }
    }
}
