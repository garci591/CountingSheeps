// -----------------------------------------------------------------------
// <copyright file="CountingSheeps.cs" company="garci591@gmail.com">
//     garci591@gmail.com Copyright © 2019
// </copyright>
// -----------------------------------------------------------------------


Repositorio donde se encuentra la Librería de CountingSheeps.

Resumen:

Dado un número entero, n, queremos devolvemos lo siguiente: 
1. Cuántos 1-bits hay en su representación binaria
2. Digamos que la representación binaria de n tiene k bits significativos indexados de 1 a k.
 Devolvemos las posiciones respectivas (es decir, en orden ascendente) de cada 1 bit
3. Optimizado para el mejor rendimiento posible.

Ejemplo: 
Función de conteo completo en la clase PositiveBitCounter. Tiene un parámetro: un número entero, n. Debe devolver un número entero 
enumerable con los siguientes valores 1 + k: 
El primer índice (0) debe contener el número total de 1 bits en la representación binaria de n. 
Los índices siguientes deben contener las posiciones respectivas de los 1-bits indexados en la representación binaria de n. 

Formato de salida: 
Devuelve un enumerable de números enteros donde el primer elemento es el número total de 1-bits en la representación binaria 
de n y los elementos subsecuentes son las respectivas ubicaciones indizadas de cada 1-bit de mayor a menor importancia. 