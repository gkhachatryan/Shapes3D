using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape3D
{
    public abstract class AbstractShape
    {
        public AbstractShape()
        {
            this.Location = new Point3D();
        }

        public AbstractShape(Point3D p)
        {
            this.Location = p;
        }

        public AbstractShape(float x, float y, float z)
        {
            this.Location = new Point3D(x, y, z);
        }

        protected float a;
        protected float b;
        protected float c;
        protected Point3D Location { get; set; }
        public abstract float Volume { get; }
        public abstract float Area { get; }

    }
}
