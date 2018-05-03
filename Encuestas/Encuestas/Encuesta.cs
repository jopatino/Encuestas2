using System;
using System.Collections.Generic;
using System.Text;

namespace Encuestas
{
    public class Encuesta
    {
        #region Propiedades
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EquipoFavorito { get; set; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return $"{Nombre}|{FechaNacimiento}|{EquipoFavorito}";
        }
        #endregion
    }
}
