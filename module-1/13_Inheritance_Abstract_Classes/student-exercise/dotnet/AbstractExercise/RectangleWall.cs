using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class RectangleWall : Wall
    {
        public int Length { get; }

        public int Height { get; }

        public RectangleWall(string name, string color, int length, int height) : base (name, color)
        {
            this.Height = height;
            this.Length = length;
        }

        public override int GetArea()
        {
           return this.Length * this.Height;
            
        }

        public override string ToString()
        {
            return Name + " (" + this.Length + "x" + this.Height + ") rectangle";
        }

    }
}
