﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidGame.VisualObjects
{
   internal abstract class VisualObject
    {
        protected Point _Position;
        protected Point _Direction;
        protected Size _Size;
        private Point position;
        private Point direction;
        private Size size;

        protected VisualObject(Point position, Point direction, Size size)
        {
            this.position = position;
            this.direction = direction;
            this.size = size;
        }

        protected VisualObject(Point Position, Point Direction, Size Size, Bitmap ship)
        {
            _Position = Position;
            _Direction = Direction;
            _Size = Size;
        }

        public int Length { get; internal set; }

        public abstract void Draw(Graphics g);
      

        public virtual void Update()
        {
            _Position.X += _Direction.X;
            _Position.Y += _Direction.Y;

            if (_Position.X < 0)
                _Direction.X *= -1;
            if (_Position.Y < 0)
                _Direction.Y *= -1;


            if(_Position.X > Game.Width)
                _Direction.X *= -1;
            if (_Position.Y > Game.Heigth)
                _Direction.Y *= -1;
        }
    }
}
 