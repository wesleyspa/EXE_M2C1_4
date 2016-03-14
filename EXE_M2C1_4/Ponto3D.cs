using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_4
{
    class Ponto3D
    {
        private int _x;
        public int x
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }

        }

        private int _y;
        public int y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }

        }

        private int _z;
        public int z
        {
            get
            {
                return this._z;
            }
            set
            {
                this._z = value;
            }

        }

        public void Mostrar()
        {
            Console.WriteLine("{0}, {1}, {2}", this.x, this.y, this.z);
        }

        public void MoverPara(int px, int py, int pz)
        {
            this.x = px;
            this.y = py;
            this.z = pz;
            Console.WriteLine("Coordenadas alteradas");
        }

        public void Distancia(Ponto3D pp2)
        {
            int dstX = this._x - pp2.x;
            int dstY = this._y - pp2.y;
            int dstZ = this._z - pp2.z;

            Console.WriteLine("Distância entre ponto X {0}", string.Format("{0:0;0}", dstX));
            Console.WriteLine("Distância entre ponto Y {0}", string.Format("{0:0;0}", dstY));
            Console.WriteLine("Distância entre ponto Z {0}\n", string.Format("{0:0;0}", dstZ));
        }
    }
}
