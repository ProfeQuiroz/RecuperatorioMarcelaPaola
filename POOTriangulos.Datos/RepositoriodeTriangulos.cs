using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOTriangulos.Entidades;

namespace POOTriangulos.Datos
{
    public class RepositoriodeTriangulos
    {
        private List<triangulo> Lista;
        private bool HayCambios = false;
        public RepositoriodeTriangulos()
        {
            Lista = new List<triangulo>();
            Lista = ManejadordeArchivoSecuencial.LeerArchivo();
        }
        public void Agregar(triangulo triangulo)
        {
            Lista.Add(triangulo);
            HayCambios = true;

        }
        public void Editar(triangulo triangulo)
        {
            HayCambios = true;
        }
        public bool Borrar(triangulo triangulo)
        {
            if (Lista.Contains(triangulo))
            {
                Lista.Remove(triangulo);
                HayCambios = true;
                return true;
            }
            return false;
        }
        public int GetCantidad()
        {
            return Lista.Count();
        }
        public void Guardar() 
        {
            if (HayCambios)
            {
                ManejadordeArchivoSecuencial.GuardarenArchivo(Lista);
            }
        }

        public List<triangulo> GetLista()
        {
            return Lista;
        }
    }


}
