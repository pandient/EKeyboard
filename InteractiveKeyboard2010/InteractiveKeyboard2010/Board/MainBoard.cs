using EyeTrackingKeyBoard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InteractiveKeyboard2010.Board;
using Microsoft.Xna.Framework;

namespace EyeTrackingKeyBoard.Board
{
    public class MainBoard :Stage
    {
        private const int NUM_HOR_KEYS = 3;
        private const int NUM_VER_KEYS = 3;
        private readonly int keyWidth;
        private readonly int keyHeight;


        public MainBoard(int width, int height):base(width, height)
        {
            keyHeight = height / NUM_VER_KEYS;
            keyWidth = width / NUM_HOR_KEYS;

            var bgColor = new Color(3, 169, 244);
            var txtColor = new Color(227, 242, 253);
            var targetStage = new SecondStage(width, height);

            var NW = new ThreeLetters("A", "B", "C", new Rectangle(0, 0, keyWidth, keyHeight), bgColor, txtColor, targetStage);
            var N = new FourLetters("D", "E","Space" ,"F", new Rectangle(keyWidth, 0, keyWidth, keyHeight), bgColor, txtColor, targetStage);
            var NE = new ThreeLetters("G", "H", "I", new Rectangle(2 * keyWidth, 0, keyWidth, keyHeight), bgColor, txtColor, targetStage);

            var W = new FourLetters("W", "X", "Y", "Z", new Rectangle(0, keyHeight, keyWidth, keyHeight), bgColor,
                                    txtColor, targetStage);

            var E = new FourLetters("J", "K", "L", "M", new Rectangle(2 * keyWidth, keyHeight, keyWidth, keyHeight), bgColor,
                                    txtColor, targetStage);


            var SW = new ThreeLetters("T", "U", "V", new Rectangle(0, keyHeight *2, keyWidth, keyHeight), bgColor, txtColor, targetStage);
            var S = new ThreeLetters("R", "S", "Q", new Rectangle(keyWidth, keyHeight * 2, keyWidth, keyHeight), bgColor, txtColor, targetStage);
            var SE = new ThreeLetters("O", "N", "P", new Rectangle(2 * keyWidth, keyHeight * 2, keyWidth, keyHeight), bgColor, txtColor, targetStage);


            this.Entities.Add(NW);
            this.Entities.Add(N);
            this.Entities.Add(NE);

            this.Entities.Add(E);
            this.Entities.Add(W);

            this.Entities.Add(SW);
            this.Entities.Add(S);
            this.Entities.Add(SE);
        }

    }
}
