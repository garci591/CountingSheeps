// -----------------------------------------------------------------------
// <copyright file="EnumsPositiveBitCounter.cs" company="garci591@gmail.com">
//     garci591@gmail.com Copyright © 2019
// </copyright>
// -----------------------------------------------------------------------

namespace CountingSheeps.Enum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Autor: Carlos García Yeves
    /// Fecha: 05/06/2019
    /// Clase que representa las enumeraciones
    /// </summary>
    public class EnumsPositiveBitCounter
    {
        /// <summary>
        /// Autor: Carlos García Yeves
        /// Fecha: 05/06/2019
        /// Enumeración que representa los valores de un numero entero no nulo.
        /// </summary>
        public enum ValuesInput
        {
            Negative = -1, //Menor que cero.
            Zero = 0,      //Igual a cero.
            Positive = 1   //Mayor que 0
        }
    }
}
