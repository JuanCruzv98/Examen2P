﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2P
{
    public class vendedorLogueado
    {
        private int _id;
        private string _nombre;

        public int id {  get { return _id; } set { _id = value; } }
        public string nombre {  get { return _nombre; } set { _nombre = value; } }
        public vendedorLogueado(int id, string nombre) { 
            this._id = id;
            this._nombre = nombre;
        }
    }
}
