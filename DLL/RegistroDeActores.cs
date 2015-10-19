using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DLL //es BLL
{
    class RegistroDeActores
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

        public bool InsertarActores()
        {
           
            Conexionsql con = new Conexionsql();
            return con.Ejecutar(String.Format("Insert Into Actores(NombreActor) Values('{0}')", this.NombreActor));
           
        }
    }
}
