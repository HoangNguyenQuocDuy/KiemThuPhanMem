using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Duy_N1_tinhte.vn
{
    public class Triangle
    {
        //Khai báo 3 cạnh của tam giác
        private double a, b, c;

        public bool IsValid()
        {
            // Kiểm tra xem tất cả các cạnh có là số dương không
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }

            // Kiểm tra bất đẳng thức tam giác
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                return false;
            }

            return true;
        }

        public Triangle(double a, double b, double c)
        {
            if (!IsValid())
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }

        public double CalculateArea()
        {
            // Công thức Heron để tính diện tích tam giác
            double s = (a + b + c) / 2; // Nửa chu vi
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}
