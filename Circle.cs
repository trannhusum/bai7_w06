using System;

namespace bai7_w06
{
    public class Circle
    {
        private string color;
        private double radius;
        public Circle()
        {
            color = "";
            radius = 0;
        }
        public Circle(string color, double radius)
        {
            this.color = color;
            this.radius = radius;
        }
        public double getArea() 
        {
            return Math.Round(radius * radius*Math.PI);
        }
        public override string ToString()
        {
            return "Radius:" + getRadius() +", Color:" + getColor();
        }
        public double getRadius() 
        {
            return radius;
        }
        public void setRadius(double radius) 
        {
            this.radius=radius;
        }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }

    }
    public class Cylinder : Circle
    {
        private double height;

        public Cylinder()
        {
            height = 0;
        }

        public Cylinder(double height, string color, double radius) : base(color, radius)
        {
            this.height = height;
        }
        public double getVolume()
        {
            return Math.Round(getRadius() * getRadius() * Math.PI * height);
        }

        public override string ToString()
        {
            return "Radius:" + getRadius() + ", Height:" + height + ", Color:" + getColor();
        }
        public void setHeight(double height)
        {
            this.height=height;
        }
        public double getHeight()
        {
            return height;
        }
    }
}
