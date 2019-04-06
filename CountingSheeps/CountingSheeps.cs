// -----------------------------------------------------------------------
// <copyright file="CountingSheeps.cs" company="garci591@gmail.com">
//     garci591@gmail.com Copyright © 2019
// </copyright>
// -----------------------------------------------------------------------

namespace CountingSheeps
{

    using Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using static Enum.EnumsPositiveBitCounter;


    /// <summary>
    /// Autor: Carlos García Yeves
    /// Fecha: 05/06/2019
    /// Clase Principal con la que podremos obtener el número de bits-1 de un número entero no nulo y sus posiciones de mayor a menor
    /// </summary>
    public class CountingSheeps
    {
        #region Contructor

        /// <summary>
        /// Autor: Carlos García Yeves
        /// Fecha: 05/06/2019
        /// Constructor principal
        /// </summary>
        public CountingSheeps() { }

        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Autor: Carlos García Yeves
        /// Fecha: 05/06/2019
        /// Obtenemos el número de bits-1 de un número entero no nulo y sus respectivas posiciones ordenadas de mayor a menor
        /// </summary>
        /// <param name="input">Número entero no nulo del cual extraemos sus bits</param>
        /// <returns>Lista de n enteros.</returns>
        public IEnumerable<int> ToBleat(int input)
        {
            try
            {
                switch (Possibilities(input))
                {
                    case ValuesInput.Negative:

                        throw new PositiveBitCounterException(); //Devolvemos una excepción controlada, ya que no es posible formatear un número entero negativo a bits.

                    case ValuesInput.Zero:

                        return new List<int> { 0 }; //Devolvemos una nueva lista con un solo valor (0), ya que el 0 no hace falta formatearlo a bits.

                    case ValuesInput.Positive:

                        return GenerateAlgorithm(input);

                    default:

                        return new List<int>();

                }
            }
            catch (PositiveBitCounterException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        /// <summary>
        /// Autor: Carlos García Yeves
        /// Fecha: 05/06/2019
        /// Algoritmo para obtener los de bits-1 de un número entero no nulo y sus respectivas posiciones ordenadas de mayor a menor
        /// </summary>
        /// <param name="input">Número entero no nulo del cual extraemos sus bits</param>
        /// <returns>Lista de n enteros.</returns>
        private IEnumerable<int> GenerateAlgorithm(int input)
        {
            try
            {
                List<int> output = new List<int>();
                var binary = Convert.ToString(input, 2).ToList(); //Obtenemos los bits de nuestro número entero no nulo.
                binary.Reverse(); //Ordenamos los bits de mayor a menor.
                AddTotalNums(ref output, binary); 
                AddPositionNums(ref output, binary); 
                return output;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Autor: Carlos García Yeves
        /// Fecha: 05/06/2019
        /// Añadimos a la lista las posiciones (representadas como número enteros) en las que se encuentran los bits-1 que tiene nuestra lista de binarios.
        /// </summary>
        /// <param name="output"> Lista de n enteros.</param>
        /// <param name="binary"> Lista de caracteres que representa nuestro número binario</param>
        private void AddPositionNums(ref List<int> output, List<char> binary)
        {
            try
            {
                output.AddRange(binary.Select((bits, position) => bits.Equals('1') ? position : -1).Where(position => position != -1));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Autor: Carlos García Yeves
        /// Fecha: 05/06/2019
        /// Añadimos a la lista el número total de bits-1 que tiene nuestra lista de binarios
        /// </summary>
        /// <param name="output"> Lista de n enteros.</param>
        /// <param name="binary"> Lista de caracteres que representa nuestro número binario</param>
        private void AddTotalNums(ref List<int> output, List<char> binary)
        {
            try
            {
                output.Add(binary.Count(x => x == '1'));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Autor: Carlos García Yeves
        /// Fecha: 05/06/2019
        /// Obtenemos las 3 posibilidades de un número entero no nulo.
        /// </summary>
        /// <param name="input">Número entero no nulo</param>
        /// <returns>Enumeración de las 3 posibilidades de un número entero no nulo.</returns>
        private ValuesInput Possibilities(int input)
        {
            if (input < 0)
            {
                return ValuesInput.Negative;
            }
            else if (input == 0)
            {
                return ValuesInput.Zero;
            }
            else
            {
                return ValuesInput.Positive;
            }
        }

        #endregion
    }
}