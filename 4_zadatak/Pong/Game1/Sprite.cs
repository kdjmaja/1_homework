using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public abstract class Sprite : IPhysicalObject2D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        /// <summary >
        /// Represents the texture of the Sprite on the screen .
        /// Texture2D is a type defined in Monogame framework .
        /// </ summary >
        public Texture2D Texture { get; set; }
        protected Sprite(int width, int height, float x = 0, float y = 0)
        {
            X = x;
            Y = y;
            Height = height;
            Width = width;
        }
        /// <summary >
        /// Base draw method
        /// </ summary >
        public virtual void DrawSpriteOnScreen(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, new Vector2(X, Y), new Rectangle(0, 0,
            Width, Height), Color.White);
        }
    }
}