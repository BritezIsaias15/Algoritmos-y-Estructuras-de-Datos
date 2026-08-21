# Fase 1: Justificación y Diseño Previo (Entrega Previa a la Programación)
Antes de escribir cualquier línea de código, el alumno deberá presentar una propuesta teórica y gráfica con los siguientes puntos:

- Justificación Técnica de Estructuras: Un documento donde se explique puntualmente por qué se eligió cada una de las 5 estructuras requeridas y qué problema específico resuelve dentro del sistema.

- Diagramas de Flujo (Flowcharts): Representación visual de los ciclos principales del programa (menús, búsqueda de productos, procesamiento de la cola de atención).

- Diagrama de Estructura del Programa: Esquema modular que muestre cómo se dividirá el código (funciones, procedimientos y el flujo de llamadas desde el método Main).

- Definición de Tipos de Datos: Tabla o ficha técnica que enumere todas las variables, structs y estructuras complejas a utilizar, detallando su tipo de dato (ej: string, int, double, Queue<Cliente>, Videojuego[]).

# Fase 2: Implementación en Código (Entrega Final)

Desarrollo de la aplicación en C# según las especificaciones del diseño previo.

Requerimientos Funcionales del Sistema:

 Módulo de Inventario (Structs + Arrays):
 
- Carga inicial y consulta de catálogo de videojuegos mediante un array de struct.

- Búsqueda de videojuegos por ID o título.

- Actualización de stock tras realizar una venta.

- Módulo de Depósito / Góndolas (Matrices):

- Una matriz string[,] o int[,] que represente la distribución física de la tienda (Filas = Pasillos, Columnas = Estantes).
  
Función para consultar qué producto está ubicado en determinada fila y columna.

Módulo de Atención a Clientes (Colas - Queue):

Registrar la llegada de un cliente a la fila de la caja.

Mostrar el estado actual de la cola (quién es el siguiente en ser atendido).

Atender al cliente (eliminarlo de la cola) e iniciar el proceso de cobro.

Menú Principal de Consola (Ciclos + Control de Flujo):

Menú interactivo dentro de un ciclo (ej. do-while) con opciones para:

Ver catálogo e inventario.

Ver mapa de góndolas.

Registrar cliente en la cola.

Atender cliente y procesar venta.

Salir.
