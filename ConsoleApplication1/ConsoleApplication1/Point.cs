using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Point
    {
        private int X, Y;

        public Point() 
        {
            this.X = this.Y;
        }
        public Point(int x, int y)
        {

        }
        public int getX()
        {
            return this.X;
        }
        public void setX(int x)
        {
            this.X = x;
        }
        public int getY()
        {
            return this.Y;
        }
        public void setY(int y)
        {
            this.Y = y;
        }
        public int[] getXY()
        {
            //int[] xy = new int[2];
            //xy[0] = this.X;
            //xy[1] = this.Y;
            //return xy;

            //tao mang nhanh hai phan tu
            return new int[] {this.X, this.Y};
        }
        public void setXY(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return String.Format("[{0}, {1}]", this.X, this.Y);
        }
        public double distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(this.X - x, 2) + Math.Pow(this.Y - y, 2);
        }
        public double distance(Point point) 
        {
            return distance(point.getX(), point.getY());
        }
        public double distance() 
        {
            return distance(0, 0);
        }
    }
}
