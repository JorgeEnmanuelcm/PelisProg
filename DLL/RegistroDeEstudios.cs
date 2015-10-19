using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DLL
{
    class RegistroDeEstudios
    {
        public int IdEstudio { get; set; }
        public string NombreEstudio { get; set; }

        public RegistroDeEstudios()
        {
            this.IdEstudio = 0;
            this.NombreEstudio = "";
        }

        public RegistroDeEstudios(int IdE, string NombreE)
        {
            this.IdEstudio = IdE;
            this.NombreEstudio = NombreE;
        }

        public bool InsertarEstudio()
        {
            bool Retornar= false;
            Conexionsql conect = new Conexionsql();
            conect.Ejecutar(String.Format("Insert Into Estudios(NombreEstudio) Values('{0}')", this.NombreEstudio));
            return Retornar;
        }
    }
}
