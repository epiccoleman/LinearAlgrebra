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

        public double x
        {
            get
            {
               return m_x;
            }
            set
            {
               m_x = value;
            }
        }

        public double y
        {
            get
            {
                return m_y;
            }
            set
            {
                m_y = value;
            }
        } 

        public Vector(double x = 0d, double y = 0d)
        {
            m_x = x;
            m_y = y;
        }
    }
}
