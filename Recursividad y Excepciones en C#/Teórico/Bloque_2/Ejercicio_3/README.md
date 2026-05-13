# Eficiencia Comparativa 

## Consigna

Investiga el concepto de "Recursión de Cola" (Tail Recursion). ¿C# optimiza este tipo de recursividad para evitar el llenado de la pila? Compara brevemente el costo de memoria entre una solución iterativa (bucle for) y una recursiva. 

## Respuesta

C# no optimiza la recursividad de cola para evitar el llenado de la pila. Un bucle for mantiene el uso de memoria de manera constante y son más rápidos en ejecutarse pero no son recomendados para problemas más complejos como el ‘Divide y Vencerás’. La recursiva consume memoria proporcional a las veces que es llamada, lo que la hace inviable para el procesamiento de datos masivos, la claridad y facilidad para demostrar la corrección de un algoritmo mediante la inducción matemática la hace favorable.
