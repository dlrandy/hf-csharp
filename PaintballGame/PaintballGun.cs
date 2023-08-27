using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballGame
{
    internal class PaintballGun
    {
        private int balls = 0;
        public int MagazineSize { get; private set; } = 16;

        public PaintballGun(int balls, int magazineSize, bool loaded) {

            this.balls = balls;
            MagazineSize = magazineSize;
            if (!loaded)
            {
                Reload();
            }
                }
        public int Balls
        {
            get
            {
                return balls;
            }
            set
            {
                if (value > 0)
                {
                    balls = value;
                }
                Reload();
            }
        }
        public int ballsLoaded
        {
            get;
           private set;
        }
        public bool IsEmpty()
        {
            return ballsLoaded == 0;
        }
     
        public void Reload() { 
        if(balls > MagazineSize)
            {
                ballsLoaded = MagazineSize;
            } else
            {
                ballsLoaded = balls;
            }
        }
        public bool Shoot() { 
        if (ballsLoaded == 0)
            {
                return false;
            }
        ballsLoaded--;
            balls--;
            return true;
        }
    }
}
