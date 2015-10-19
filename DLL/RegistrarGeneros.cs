using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace DLL // es BLL
{
    public class RegistrarGeneros: ClaseMaestra
    {
        public int IdGeneros { get; set; }   
        public string DescripcionDeGeneros  { get; set; }

        public RegistrarGeneros()
        {
            this.IdGeneros = 0;
            this.DescripcionDeGeneros = "";
        }
   
        public RegistrarGeneros(int idgeneros, string descripciondegeneros)
        {
            this.IdGeneros = idgeneros;
            this.DescripcionDeGeneros = descripciondegeneros;
        }

        public override bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public override bool Insertar()
        {
            Conexionsql conect = new Conexionsql();

           return  conect.Ejecutar(String.Format("Insert Into Generos(Descripcion) Values('{0}')", this.DescripcionDeGeneros));

        }

        public override bool Eliminar(int id)
        {
            Conexionsql con = new Conexionsql();
            return con.Ejecutar(String.Format("Delete *From where GeneroId= {0}", id));
        }

        public override DataTable Listar(string campos, string filtros)
        {
            Conexionsql con = new Conexionsql();
            return con.ObtenerDatos("Select " + campos + " from Generos where" + filtros);
        }
    }
}


 
