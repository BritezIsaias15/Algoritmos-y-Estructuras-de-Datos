# Sistema de "Deshacer" (Undo) para un Editor 

**Enunciado:** Imagina un editor de texto muy simple. Crea un programa que acepte tres tipos de comandos por consola:escribir [texto]: Añade texto a un string principal.deshacer: Revierte la última acción de escritura eliminando lo que se escribió.mostrar: Imprime el estado actual del texto.

- Reto extra: Usa una estructura o clase para guardar no solo el texto, sino el tipo de acción, por si decides implementar también un botón de "Rehacer" (Redo).

- **Qué practicas:** Guardar objetos complejos dentro de una pila (Stack<Accion>).
