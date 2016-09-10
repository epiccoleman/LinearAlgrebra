using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebra
{
    class Vector
    {

        private double m_x;
        private double m_y;
        private double m_z;

        public double x
        {
            get { return m_x; }
            set { m_x = value; }
        }

        public double y
        {
            get { return m_y; }
            set { m_y = value; }
        }

        public double z
        {
            get { return m_z; }
            set { m_z = value; }
        }

        public Vector(double x = 0d, double y = 0d, double z = 0d)
        {
            m_x = x;
            m_y = y;
            m_z = z;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            double new_x = v1.x + v2.x;
            double new_y = v1.y + v2.y;
            double new_z = v1.z + v2.z;

            return new Vector(new_x, new_y, new_z);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !v1.Equals(v2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Vector other = obj as Vector;
            if ((System.Object)other == null)
            {
                return false;
            }

            return x == other.x && y == other.y && z == other.z;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
