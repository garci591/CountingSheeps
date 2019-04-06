// -----------------------------------------------------------------------
// <copyright file="CountingSheeps.cs" company="garci591@gmail.com">
//     garci591@gmail.com Copyright � 2019
// </copyright>
// -----------------------------------------------------------------------


Repositorio donde se encuentra la Librer�a de CountingSheeps.

Resumen:

Dado un n�mero entero, n, queremos devolvemos lo siguiente: 
1. Cu�ntos 1-bits hay en su representaci�n binaria
2. Digamos que la representaci�n binaria de n tiene k bits significativos indexados de 1 a k.
 Devolvemos las posiciones respectivas (es decir, en orden ascendente) de cada 1 bit
3. Optimizado para el mejor rendimiento posible.

Ejemplo: 
Funci�n de conteo completo en la clase PositiveBitCounter. Tiene un par�metro: un n�mero entero, n. Debe devolver un n�mero entero 
enumerable con los siguientes valores 1 + k: 
El primer �ndice (0) debe contener el n�mero total de 1 bits en la representaci�n binaria de n. 
Los �ndices siguientes deben contener las posiciones respectivas de los 1-bits indexados en la representaci�n binaria de n. 

Formato de salida: 
Devuelve un enumerable de n�meros enteros donde el primer elemento es el n�mero total de 1-bits en la representaci�n binaria 
de n y los elementos subsecuentes son las respectivas ubicaciones indizadas de cada 1-bit de mayor a menor importancia. 