using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            BoundingBox bb1 = new BoundingBox(new Vector3(a.X, a.Y, 0),
                                              new Vector3(a.X + a.Width, a.Y + a.Height, 0));

            BoundingBox bb2 = new BoundingBox(new Vector3(b.X, b.Y, 0),
                                              new Vector3(b.X + b.Width, b.Y + b.Height, 0));
            if (bb1.Intersects(bb2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}