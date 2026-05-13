#  El Contador de Dígitos

## Consigna

En lugar de usar un arreglo, vamos a descomponer un número entero. 

- **El Reto:** Crea una función recursiva ContarDigitos(int n) que devuelva cuántos dígitos tiene un número. 

- **Pista Matemática:** Si divides un entero entre 10 en C# (ej. 125 / 10), el resultado es 12. Has "eliminado" un dígito.

- **Caso Base:** Cuando el número es menor a 10, solo tiene 1 dígito. 
 
- **Caso Recursivo:** 1 + ContarDigitos(n / 10).
