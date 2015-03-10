using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EyeTrackingKeyBoard;

namespace InteractiveKeyboard2010.Entities
{
    public class Letter : Entity
    {


        public Letter(Microsoft.Xna.Framework.Graphics.Texture2D texture, Microsoft.Xna.Framework.Rectangle Rectangle, Microsoft.Xna.Framework.Color BGColor, Microsoft.Xna.Framework.Color TextColor)
        {
            
            this.Texture = texture;
            this.Rectangle = Rectangle;
            this.BGColor = BGColor;
            this.TextColor = TextColor;
        }

        public Letter(Microsoft.Xna.Framework.Rectangle Rectangle, Microsoft.Xna.Framework.Color BGColor, Microsoft.Xna.Framework.Color TextColor)
            : base(Rectangle, BGColor, TextColor)
        {
            int i = 2;
        }
    }
}
