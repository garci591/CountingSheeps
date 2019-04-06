// -----------------------------------------------------------------------
// <copyright file="PositiveBitCounterException.cs" company="garci591@gmail.com">
//     garci591@gmail.com Copyright © 2019
// </copyright>
// -----------------------------------------------------------------------

namespace CountingSheeps.Exceptions
{

    using System;

    /// <summary>
    /// Autor: Carlos García Yeves
    /// Fecha: 05/06/2019
    /// Clase que representa las excepciones controladas, heredamos de Exception
    /// </summary>
    public class PositiveBitCounterException : Exception
    {
        #region Constructores sobrecargados

        /// <summary>
        /// Autor: Carlos García Yeves
        /// Fecha: 05/06/2019
        /// Representa las excepcines controladas de un entero no nulo menor que 0
        /// </summary>
        public PositiveBitCounterException() : base("Not allowed negative numbers in this test")
        {

        }

        /// <summary>
        /// Autor: Carlos García Yeves
        /// Fecha: 05/06/2019
        /// Representa la excepción controlada de un entero no nulo menor que 0
        /// </summary>
        /// <param name="message">string que representa el mensaje de error</param>
        public PositiveBitCounterException(string message) : base(message)
        {

        }

        /// <summary>
        /// Autor: Carlos García Yeves
        /// Fecha: 05/06/2019
        /// Representa la excepción controlada de un entero no nulo menor que 0
        /// </summary>
        /// <param name="message">string que representa el mensaje de error</param>
        /// <param name="inner">exception que representar el objeto</param>
        public PositiveBitCounterException(string message, Exception inner)
        : base(message, inner)
        {

        }

        #endregion
    }
}
