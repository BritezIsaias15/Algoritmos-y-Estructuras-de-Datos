# Estrategia "Divide y Vencerás" 

## Consigna 

¿Cómo utiliza la Búsqueda Binaria la recursividad para reducir la complejidad temporal a O(log n)? 

## Respuesta

Lo facilita al descartar la mitad de los elementos. Primero busca el punto medio, compara el punto medio con el objetivo y se vuelve a ejecutar la función, pero si el objetivo es menor, reemplaza el máximo con el punto medio menos uno, y si es mayor reemplaza el punto mínimo con el punto medio más uno. Se repite hasta que solo quede 1 elemento.
