# Anatomía de la Memoria (The Stack) 

## Consigna

Explica técnicamente qué sucede en la Pila de Llamadas (Call Stack) de C# cuando se produce un error de StackOverflowException por una recursión infinita. 

## Respuesta

Cuando se produce el error StackOverflowException el proceso se ve forzado a terminar de manera inmediata por haber llegado al límite físico impuesto por el sistema (call stack), que suele ser de 1MB. Esto pasa porque al usar una recursión infinita el CLR (Common Language Runtime) asigna nuevos bloques para guardar los datos.
