using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DLL //es BLL
{
    public class RegistroDeActores : ClaseMaestra
    {
        public int IdActor { get; set; }
        public string NombreActor { get; set; }

        public RegistroDeActores()
        {
            this.IdActor = 0;
            this.NombreActor = "";
        }

        public RegistroDeActores(int IdA, string NombreA)
        {
            this.IdActor = IdA;
            this.NombreActor = NombreA;
        }


        public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Insertar()
        {
            Conexionsql cone = new Conexionsql();
            return  cone.Ejecutar(String.Format("Insert Into Actores(NombreActor) Values('{0}')", this.NombreActor));
        }

        public override bool Eliminar(int id)
        {
            Conexionsql cone = new Conexionsql();
            return cone.Ejecutar(String.Format("Delete *From where ActorId= {0}", id)); 
        }

        public override bool Buscar(int idbuscar)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listar(string campos, string filtros)
        {
             Conexionsql cone = new Conexionsql();
             return cone.ObtenerDatos("Select " + campos + " from Actores where" + filtros);
        }
    }
}
