using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InteractiveKeyboard2010.Board;

namespace EyeTrackingKeyBoard.Entities
{
    public class FourLetters : Entity
    {
        public String L1 { get; set; }
        public String L2 { get; set; }
        public String L3 { get; set; }
        public String L4 { get; set; }
        private Vector2 nw;
        private Vector2 ne;
        private Vector2 sw;
        private Vector2 se;
        public SecondStage TargetStage;



        public FourLetters(string l1, string l2, String l3,String l4 ,  Rectangle Rectangle, Color BGColor, Color TextColor, SecondStage target)
            : base(Rectangle, BGColor, TextColor)
        {
            this.L1 = l1;
            this.L2 = l2;
            this.L3 = l3;
            this.L4 = l4;
            int LetterHeight = (int)Static.SpriteFont.MeasureString(L1).Y;
            int LetterWidth = (int) Static.SpriteFont.MeasureString(L2).X;

            nw = new Vector2(Rectangle.X, Rectangle.Y);
            ne = new Vector2(Rectangle.Right - LetterWidth, Rectangle.Y);
            sw = new Vector2(Rectangle.X, Rectangle.Bottom - LetterHeight);
            se = new Vector2(Rectangle.Right - LetterWidth, Rectangle.Bottom - LetterHeight);
            TargetStage = target;
        }

        public override void Draw(GameTime gameTime)
        {
            if(IsHighlighted)
            {
                Static.SpriteBatch.Draw(this.Texture, Rectangle, Color.Gold); 
            }else
            {
                Static.SpriteBatch.Draw(this.Texture, Rectangle, BGColor); 
            }

            
            Static.SpriteBatch.DrawString(Static.SpriteFont, L1, nw, TextColor);
            Static.SpriteBatch.DrawString(Static.SpriteFont, L2, ne, TextColor);
            Static.SpriteBatch.DrawString(Static.SpriteFont, L3, sw, TextColor);
            Static.SpriteBatch.DrawString(Static.SpriteFont, L3, se, TextColor);
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            if(IsSelected)
            {
                TargetStage.Intialize(this);
                Static.CurrentStage = TargetStage;
            }
            base.Update(gameTime);
        }


    }
}
