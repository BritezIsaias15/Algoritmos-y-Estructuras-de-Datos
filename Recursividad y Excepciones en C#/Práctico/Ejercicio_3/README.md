# Inversión de Números

## Consigna

Este ejercicio ayuda a entender cómo la recursividad "espera" a que las llamadas hijas terminen.

- **El Reto:** Imprimir un número al revés (ej: entras `1234`, sale `4321`) sin usar `string.Reverse()` ni arreglos.
  
- **Lógica:** 1.  Imprime el último dígito usando el operador residuo: `Console.Write(n % 10)`.

2.  Llama a la función de nuevo con `n / 10`.
   
4.  **Caso Base:** Cuando `n < 10`, imprimes el número y terminas.
