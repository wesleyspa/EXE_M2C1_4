using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_M2C1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<Ponto3D> ponto = new System.Collections.Generic.List<Ponto3D>();

            for(int i = 0; i < 3; i++)
            {
                ponto.Add(new Ponto3D());         
                       
                Console.WriteLine("Digite a coordenada X do ponto {0}", i + 1);
                ponto[i].x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a coordenada Y do ponto {0}", i + 1);
                ponto[i].y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite a coordenada Z do ponto {0}", i + 1);
                ponto[i].z = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = 0; i < 2; i++)
            {
                ponto[i].Distancia(ponto[i + 1]);
            }
        }
    }
}
