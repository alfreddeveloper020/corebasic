using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBasico.Models
{
    public class Usuarios
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string clave { get; set; }
        public Nullable<int> estado { get; set; }
        public string genero { get; set; }
        public Nullable<int> edad { get; set; }
        public string ciudad { get; set; }
    }
}
