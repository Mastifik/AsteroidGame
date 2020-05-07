using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AsteroidGame.VisualObjects
{
    internal  class HP : ImageObject
    {
        public HP(Point Position, Point Direction, int ImageSize) : //base(Position, Direction, new Size(ImageSize, ImageSize), __Image)
            base(Position, Direction, new Size(ImageSize, ImageSize), Properties.Resources.Health)
        {

        }

        public HP SpaceShip;
        public int addHP = 1;
        private static Rect Rect;

        public void OnTriggerEnter(SpaceShip MySpaceShip)
        {
            var MySpaceShip = Rect.IntersectsWith(HP.Rect);

            if (MySpaceShip && addHP is SpaceShip)
            {
                SpaceShip.HP += addHP;
                Destoyed (VisualObject HP)
            }

        }




    }
}

