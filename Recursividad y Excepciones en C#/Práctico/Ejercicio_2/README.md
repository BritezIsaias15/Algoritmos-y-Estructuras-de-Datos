# La Potencia Segura

## Consigna

Vamos a calcular a^b (a elevado a la b) pero protegiendo el programa de entradas inválidas.

- **El Reto:** 1.  Escribe el método recursivo `CalcularPotencia(int base, int exponente)`.

2.  **Caso Base:** Si `exponente == 0`, retorna 1.
   
4.  **Manejo de Errores:** En el `Main`, usa un bloque `try-catch` para capturar si el usuario ingresa letras en lugar de números (`FormatException`).
   
6.  **Validación Manual:** Si el usuario ingresa un exponente negativo, lanza una `Exception` con el mensaje: "Esta función no soporta exponentes negativos".
   
