# 1. El Reversor de Palabras
   
**Enunciado:** Escribe un programa que pida al usuario una cadena de texto (una palabra o frase) y utilice una pila para invertirla. El programa debe meter cada carácter en la pila y luego sacarlos uno a uno para construir la cadena invertida.

 - **Qué practicas:** Operaciones básicas como Push() (insertar) y Pop() (extraer).
   
# 2. Validador de Paréntesis Balanceados
   
**Enunciado:** Crea una función que reciba una cadena de texto que representa una expresión matemática (por ejemplo: ((a + b) * (c - d))). El programa debe determinar si los paréntesis están correctamente balanceados usando una pila.

 - Pista: Cada vez que encuentres un (, súbelo a la pila. Cada vez que encuentres un ), saca un elemento. Si al final la pila está vacía y nunca intentaste sacar algo de una pila vacía, está balanceada.
   
 - **Qué practicas:** Condicionales con pilas y el método Count o TryPop().
   
# 3. El Historial del Navegador Web
   
**Enunciado:** Simula el comportamiento de los botones "Ir a página" y "Atrás" de un navegador web. El usuario puede escribir una URL para visitarla, o escribir la palabra "atras" para regresar a la página anterior. Usa una pila para almacenar el historial de navegación de modo que el comando "atras" te devuelva siempre la última página visitada.

 - **Qué practicas:** Simulación de estados y manejo de flujos basados en LIFO.
   
# 4. Sistema de "Deshacer" (Undo) para un Editor
   
**Enunciado:** Imagina un editor de texto muy simple. Crea un programa que acepte tres tipos de comandos por consola:escribir [texto]: Añade texto a un string principal.deshacer: Revierte la última acción de escritura eliminando lo que se escribió.mostrar: Imprime el estado actual del texto.

 - Reto extra: Usa una estructura o clase para guardar no solo el texto, sino el tipo de acción, por si decides implementar también un botón de "Rehacer" (Redo).

 - **Qué practicas:** Guardar objetos complejos dentro de una pila (Stack<Accion>).
