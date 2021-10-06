using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_Assignment_2
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int _length, int _width)
        {
            length = _length;
            width = _width;
        }

        public int GetRectangleLength()
        {
            return this.length;
        }

        public int SetRectangleLength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int GetRectangleWidth()
        {
            return this.width;
        }

        public int SetRectangleWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetRectanglePerimeter()
        {
            return 2 * (this.length + this.width);
        }
        public int GetRectangleArea()
        {
            return this.length * this.width;
        }
    }

}

