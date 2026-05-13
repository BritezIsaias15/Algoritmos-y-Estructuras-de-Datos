# Ciclo de Vida de una Excepción 

## Consigna

¿Cuál es la diferencia fundamental entre los bloques catch y finally? Investiga si es posible tener un bloque try seguido únicamente de un bloque finally sin capturar ninguna excepción. 

## Respuesta 

La diferencia entre esos dos bloques es que catch sirve para verificar si hay alguna excepción en el código, y si la hay, ir al catch específico y volver al código original, a menos de que haya un throw. Mientras que finally siempre se ejecuta al final y no se puede interrumpir.
