using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape3D
{
    public class Parallelepiped : AbstractShape
    {
       

        public Parallelepiped(float A, float B, float C)
        {

            base.a = A;
            base.b = B;
            base.c = B;

        }

        public override float Volume
        {
            get
            {
                return (a * b * c);
            }
        }

        public override float Area
        {
            get
            {
                return 2 * (a * b + a * c + b * c);
            }
        }
    }
}
