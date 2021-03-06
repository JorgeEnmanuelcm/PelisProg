﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DLL
{
    public abstract class ClaseMaestra
    {
        public abstract bool Editar();
        public abstract bool Insertar();
        public abstract bool Eliminar(int id);
        public abstract bool Buscar(int idbuscar);
        public abstract DataTable Listar(string campos, string filtros);
    }
}
