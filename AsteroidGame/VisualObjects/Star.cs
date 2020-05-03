using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteroidGame.VisualObjects
{
    class Star : VisualObject
    {
        private Point point1;
        private Point point2;
        private int v;

        /* public Star(Point point1, Point point2, int v)
         {
             this.point1 = point1;
             this.point2 = point2;
             this.v = v;
         }*/



        public Star(Point Position, Point Direction, int Size) : base(Position, Direction, new Size(Size, Size))
        {

        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(Pens.WhiteSmoke,
                _Position.X, _Position.Y,
                _Position.X + _Size.Width,
                _Position.Y + _Size.Height);

            g.DrawLine(Pens.White,
                _Position.X + _Size.Width,
                _Position.Y, _Position.X,
                _Position.Y + _Size.Height);
        }


        public override void Update()
        {
            _Position.X += _Direction.X;
            if (_Position.X < 0)
                _Position.X = Game.Width + _Size.Width;
        }

    }
}
