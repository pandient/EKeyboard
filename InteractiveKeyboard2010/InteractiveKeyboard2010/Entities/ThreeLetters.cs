using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InteractiveKeyboard2010.Board;
using InteractiveKeyboard2010.Entities;

namespace EyeTrackingKeyBoard.Entities
{
    public class ThreeLetters : Letter
    {
        public String L1 { get; set; }
        public String L2 { get; set; }
        public String L3 { get; set; }
        private Vector2 top;
        private Vector2 right;
        private Vector2 left;
        public SecondStage TargetStage;


        public ThreeLetters(string l1, string l2, String l3,  Texture2D texture, Rectangle Rectangle, Color BGColor, Color TextColor)
            : base(texture, Rectangle, BGColor, TextColor)
        {
            this.L1 = l1;
            this.L2 = l2;
            this.L3 = l3;
        }

        public ThreeLetters(string l1, string l2, String l3, Rectangle Rectangle, Color BGColor, Color TextColor, SecondStage target)
            : base(Rectangle, BGColor, TextColor)
        {
            this.L1 = l1;
            this.L2 = l2;
            this.L3 = l3;
            int LetterHeight = (int)Static.SpriteFont.MeasureString(L1).Y;
            int LetterWidth = (int) Static.SpriteFont.MeasureString(L2).X;
            top = new Vector2(Rectangle.Center.X, Rectangle.Y);
            left = new Vector2(Rectangle.X, Rectangle.Bottom - LetterHeight);
            right = new Vector2(Rectangle.Right - LetterWidth, Rectangle.Bottom - LetterHeight);
            TargetStage = target;
        }

        public override void Draw(GameTime gameTime)
        {
            if(IsHighlighted)
            {
                var tmpColor = new Color((Color.Red.R), 0f, 0f);

                Static.SpriteBatch.Draw(this.Texture, Rectangle, Color.Red); 
                Debug.WriteLine(tmpColor.R + " " + this.FocusTime);
            }else
            {
                Static.SpriteBatch.Draw(this.Texture, Rectangle, BGColor); 
            }

            
            Static.SpriteBatch.DrawString(Static.SpriteFont, L1, top, TextColor);
            Static.SpriteBatch.DrawString(Static.SpriteFont, L2, left, TextColor);
            Static.SpriteBatch.DrawString(Static.SpriteFont, L3, right, TextColor);

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
