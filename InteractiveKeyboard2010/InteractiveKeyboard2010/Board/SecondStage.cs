using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EyeTrackingKeyBoard;
using EyeTrackingKeyBoard.Entities;
using Microsoft.Xna.Framework;

namespace InteractiveKeyboard2010.Board
{
    public class SecondStage : Stage
    {

        private const int NUM_HOR_KEYS = 3;
        private const int NUM_VER_KEYS = 3;
        private readonly int keyWidth;
        private readonly int keyHeight;

        

        private String L1 = "";
        private String L2 = "";
        private String L3 = "";
        private String L4 = "";
        public SecondStage(int width , int height) : base(width, height)
        {
            keyHeight = height / NUM_VER_KEYS;
            keyWidth = width / NUM_HOR_KEYS;

            
        }

        public void Intialize(ThreeLetters threeLetters)
        {
         
            this.Entities.Clear();

            var bgColor = new Color(3, 169, 244);
            var txtColor = new Color(227, 242, 253);

            var Top = new SingleLetter(threeLetters.L1, new Rectangle(keyWidth, 0, keyWidth, keyHeight), bgColor, txtColor);
            var Left = new SingleLetter(threeLetters.L2, new Rectangle(0, keyHeight * 2, keyWidth, keyHeight), bgColor, txtColor);
            var Right = new SingleLetter(threeLetters.L3, new Rectangle(keyWidth * 2, keyHeight * 2, keyWidth, keyHeight), bgColor, txtColor);


            this.Entities.Add(Top);
            this.Entities.Add(Left);
            this.Entities.Add(Right);    
        }

        public void Intialize(FourLetters fourLetters)
        {
            
            this.Entities.Clear();

            var bgColor = new Color(3, 169, 244);
            var txtColor = new Color(227, 242, 253);

            var NW = new SingleLetter(fourLetters.L1, new Rectangle(0, 0, keyWidth, keyHeight), bgColor, txtColor);
            var NE = new SingleLetter(fourLetters.L2, new Rectangle(keyWidth * 2, 0, keyWidth, keyHeight), bgColor, txtColor);
            var SW = new SingleLetter(fourLetters.L3, new Rectangle(0, keyHeight * 2, keyWidth, keyHeight), bgColor, txtColor);
            var SE = new SingleLetter(fourLetters.L4, new Rectangle(keyWidth * 2, keyHeight * 2, keyWidth, keyHeight), bgColor, txtColor);


            this.Entities.Add(NW);
            this.Entities.Add(NE);
            this.Entities.Add(SW);
            this.Entities.Add(SE);
        }

        


    }
}
