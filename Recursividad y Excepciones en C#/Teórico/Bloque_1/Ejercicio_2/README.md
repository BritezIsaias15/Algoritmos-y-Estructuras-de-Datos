# Jerarquía de Excepciones 

## Consigna

¿Por qué se considera una mala práctica capturar siempre la clase base Exception en lugar de excepciones específicas como FormatException o DivideByZeroException?

## Respuesta

Se considera una mala práctica porque la clase base Exception agarra todas las anomalías que encuentre y eso nos deja con una excepción que no sabemos de donde viene o como solucionarlo. Es recomendable usar excepciones específicas por la facilidad de encontrar las anomalías.
