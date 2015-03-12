using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace EyeTrackingKeyBoard.Entities
{
    public class SingleLetter : Entity
    {
        public String Letter { get; set; }


        public SingleLetter(String Text)
        {
            // this.position = position;
            this.Letter = Text;
        }

        public SingleLetter(String Text, Rectangle rectangle, Color bgColor, Color textColor)
            : base(rectangle, bgColor, textColor)
        {
            this.Letter = Text;
        }


        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime)
        {

            if (IsHighlighted)
            {
                Static.SpriteBatch.Draw(Texture, Rectangle, Color.Gold);
            }
            else
            {
                Static.SpriteBatch.Draw(Texture, Rectangle, BGColor);
            }
            Static.SpriteBatch.DrawString(Static.SpriteFont, Letter, new Vector2(Rectangle.Center.X, Rectangle.Center.Y), TextColor);
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            if (this.IsSelected)
            {


                if (Letter.ToLower() == "space")
                {

                    Static.Text += " ";
                }
                else
                {
                    Static.Text += Letter;
                }
                Static.CurrentStage = Static.MainStage;
                if (Static.Text.Length % 15 == 0)
                {
                    Static.Text += "\n";
                }
            }
            base.Update(gameTime);

        }
    }
}
