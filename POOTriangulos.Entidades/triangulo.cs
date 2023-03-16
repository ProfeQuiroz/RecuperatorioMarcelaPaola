using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOTriangulos.Entidades
{
    public class triangulo
    {
        public double ladoa { get; set; }
        public double ladob { get; set; }
        public double ladoc { get; set; }
        public Trazo Trazo { get; set; }

        public ColordeRelleno ColordeRelleno { get; set; }

        public double GetPerimetro()
        {
            return ladoa + ladob + ladoc;
        }
        public double GetArea()
        {
            var s = (ladoa + ladob + ladoc) / 2;
            var a = Math.Sqrt(s * (s - ladoa) * (s - ladob) * (s - ladoc));
            return a;
        }
        public bool ValidarTriangulo()
        {
            if (ladoa + ladob > ladoc && ladoa + ladoc > ladob && ladob + ladoc > ladoa)
            {
                return true;
            }
            return false;
        }
        public string Tipodetriangulo()
        {
            string Tipo;
            if(ladoa==ladob&&ladob==ladoc)
            {
                Tipo = "Equilatero ";
            }
            else
            {
                if (ladoa != ladob && ladob != ladoc&&ladoa!=ladoc)
                {
                    Tipo = " Escaleno";
                }
                else
                    {
                    Tipo = "Isosceles";
                    }
            }
            return Tipo;       
        }

    }
}
