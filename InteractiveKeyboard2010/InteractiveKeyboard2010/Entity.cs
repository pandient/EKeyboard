using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EyeTrackingKeyBoard
{
    public class Entity : DrawableGameComponent
    {
        
        public Texture2D Texture { get; set; }
        public Rectangle Rectangle { get; set; }
        public Color BGColor { get; set; }
        public Color TextColor { get; set; }
        public bool IsSelected = false;
        public bool IsHighlighted = false;


        public Entity() :base(Static.Game)
        {

        }

        public Entity( Texture2D texture, Rectangle rectangle, Color bgColor, Color textColor)
            : base(Static.Game)
        {
           
            this.Texture = texture;
            this.Rectangle = rectangle;
            this.BGColor = bgColor;
            this.TextColor = textColor;
        }

        public Entity( Rectangle Rectangle, Color BGColor, Color TextColor)
            : base(Static.Game)
        {
           
            this.Rectangle = Rectangle;
            this.BGColor = BGColor;
            this.TextColor = TextColor;

            var text = new Texture2D(Static.graphics.GraphicsDevice, 1, 1);
            text.SetData(new[] { BGColor });
            this.Texture = text;
        }

        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {

            base.Draw(gameTime);
        }

    }
}
