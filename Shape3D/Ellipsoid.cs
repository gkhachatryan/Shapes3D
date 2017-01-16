using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape3D
{
    public class Ellipsoid : AbstractShape, IMoveable
    {
        
        public Ellipsoid(float A, float B, float C)
        {
            base.a = A;
            base.b = B;
            base.c = B;
        }

        private const double p = 1.6075;

        public override float Volume
        {
            get
            {
                return 4f / 3f * (float)Math.PI * a * b * c;
            }
        }

        public override float Area
        {
            get
            {
                return (float)(4 * Math.PI * Math.Pow((Math.Pow(a * b, p) + Math.Pow(a * c, p) + Math.Pow(b * c, p)) / 3, 1 / p));
            }
        }


        public void MoveBy(float dx, float dy, float dz)
        {
            var p = new Point3D();

            p.X = this.Location.X + dx;
            p.Y = this.Location.Y + dy;
            p.Z = this.Location.Z + dz;

            this.Location = p;
        }


        public void MoveTo(float x, float y, float z)
        {
            this.Location = new Point3D(x, y, z);
        }


        public void MoveTo(Point3D p)
        {
            this.Location = p;
        }


    }
}
