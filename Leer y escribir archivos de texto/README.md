# Ejercicio 1: Escritor de Notas Diario (Modo Sobrescribir vs. Modo Añadir)
**Objetivo:** Comprender la diferencia entre crear un archivo desde cero y añadir contenido al final (append).

**Consigna**
1. Crea un programa que le pida al usuario su nombre y su frase favorita.
2. Guarda estos datos en un archivo llamado diario.txt utilizando StreamWriter.
3. Vuelve a ejecutar el programa o añade un segundo bloque para agregar la fecha actual al mismo archivo sin borrar lo anterior (append: true).

# Ejercicio 2: Lectura Línea por Línea con Bucle while y Control de Excepciones
**Objetivo:** Implementar la lectura estructurada de un archivo manejando posibles errores de E/S (archivos inexistentes) mediante try-catch-finally.

**Consigna**
1. Solicita al usuario el nombre o la ruta de un archivo de texto.
2. Abre el archivo con StreamReader dentro de un bloque try-catch-finally.
3. Lee y muestra cada línea en la consola numerando cada renglón (ejemplo: 1: Hola, 2: Mundo).
4. Asegúrate de cerrar el flujo en la sección finally.

# Ejercicio 3: Analizador de Texto (Conteo e Inspección con Peek y ReadToEnd)
**Objetivo:** Trabajar con diferentes métodos de lectura de StreamReader (ReadToEnd y Peek).

**Consigna**
1. Crea un programa que lea el archivo diario.txt generado en el Ejercicio 1.
2. Utiliza sr.Peek() para comprobar si el archivo tiene contenido antes de comenzar a leer.
3. Utiliza sr.ReadToEnd() para obtener todo el contenido en un solo string.
4. Muestra en consola:
- Todo el contenido del archivo.
- La cantidad total de caracteres.
- La cantidad total de palabras.

# Ejercicio 4: Generador de Tablas Numéricas con Codificación (Encoding.ASCII / UTF8)
**Objetivo:** Practicar el uso de iteraciones para escribir datos continuos sin salto de línea (Write) y el uso de codificaciones de texto especificadas en los constructores. 

**Consigna**
1. Usa StreamWriter especificando la codificación Encoding. UTF8 para crear el archivo tabla_multiplicar.txt.
2. Utiliza un bucle para escribir la tabla de multiplicar del 7 (del 1 al 10).
3. Utiliza Write() en lugar de WriteLine() para generar una fila de números separados por guiones en una misma línea y WriteLine() solo para separar secciones.
