using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modulo3
{
    public class Estudiante
    {
        public int Id { get; set; }
        private string _nombre;
        public string Nombre { 
            get { return _nombre; }
            set {
                _nombre = string.Join(' ', value.Split(' ')
              .Select(x => x[0].ToString().ToUpper() + x.Substring(1).ToLower()).ToArray());
            }
        }
        public DateTime FechaNacimiento { get; set; }

    }
}
