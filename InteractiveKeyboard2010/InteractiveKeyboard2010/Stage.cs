using InteractiveKeyboard2010.Input;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;

namespace EyeTrackingKeyBoard
{
    public class Stage : DrawableGameComponent
    {
        public List<Entity> Entities;
        public int Width { get; set; }
        public int Height { get; set; }

        public Stage(int width, int height):base(Static.Game)
        {
            this.Width = width;
            this.Height = height;
            this.Entities = new List<Entity>();
        }

        public override void Draw(GameTime gameTime)
        {
            int len = Entities.Count();
           
            for (int i = 0; i < len; i++)
            {
                Entities[i].Draw(gameTime);
                
            }
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime)
        {
            UpdateEntitySelection();
            int len = Entities.Count();
            Entity tmp = null;

            for (int i = 0; i < len; i++)
            {
                tmp = Entities[i];
                tmp.Update(gameTime);
                
            }

            base.Update(gameTime);
        }

        public void UpdateEntitySelection()
        {
            
            foreach (var entity in Entities)
            {
                entity.IsHighlighted = false;
                entity.IsSelected = false;
                if(entity.Rectangle.Contains((int)GazePoint.X,(int)GazePoint.Y))
                {
                    entity.IsHighlighted = true;
                    if(Input.IsLeftClick())
                    {
                        entity.IsSelected = true;
                    }
                }
            }
        }
    }
}
