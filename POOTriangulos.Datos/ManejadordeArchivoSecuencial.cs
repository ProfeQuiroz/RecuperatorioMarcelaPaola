using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOTriangulos.Entidades;

namespace POOTriangulos.Datos
{
    public class  ManejadordeArchivoSecuencial
    {
        private static string archivo = "ArchivoTriangulo";
        public static void GuardarenArchivo(List<triangulo> ListadeTriangulos)
        {
            using (var Escritor = new StreamWriter(archivo))
            {
                foreach (var Triangulo in ListadeTriangulos)
                {
                    string Linea = ConstruirLinea(Triangulo);
                    Escritor.WriteLine(Linea);
                }

            }
        }

        private static string ConstruirLinea(triangulo triangulo)
        {
            return $"{triangulo.ladoa}|{triangulo.ladob}|{triangulo.ladoc}|{(int)triangulo.ColordeRelleno}|{(int)triangulo.Trazo}";

        }
        public static List<triangulo> LeerArchivo()
        {
            List<triangulo> Lista = new List<triangulo>();
            if (File.Exists(archivo))
            {
                using (var Lector=new StreamReader(archivo))
                {
while (!Lector.EndOfStream)
                    {
                        string Linea = Lector.ReadLine();
                        triangulo triangulo = ConstruirTriangulo(Linea);
                        Lista.Add(triangulo);
                    }
                       
                }
            }
            return Lista;
        }

        private static triangulo ConstruirTriangulo(string linea)
        {
            var campos=linea.Split('|');
            triangulo Triangulo = new triangulo()
            {
                ladoa = int.Parse(campos[0]),
                ladob = int.Parse(campos[1]),
                ladoc = int.Parse(campos[2]),
              
                ColordeRelleno = (ColordeRelleno)int.Parse(campos[3]),
                Trazo = (Trazo)int.Parse(campos[4])
            };
            return Triangulo;

        }
    }
}
