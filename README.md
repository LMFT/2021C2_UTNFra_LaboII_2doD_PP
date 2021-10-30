# Título: Simple Cibercontrol
*UTNFra Laboratorio de Computación II - Primer Parcial - Comisión 2do D - 2do cuatrimestre 2021*

[Enunciado del parcial](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/evaluaciones/parciales/2d-primer-parcial/)

## Sobre mí
Mi nombre es Lucas, actualmente estudiante de la carrera de programacion en la UTN FRA. Este es mi primer proyecto de programación en el cual me enfrento al desafío de
de diseñar una app desde 0, partiendo desde determinadas pautas a cumplir y nada más. Fue un desafio interesante, dado que, al ser la primera vez, me sentí bastante abrumado por las cosas que hacer, y cometí muchos errores de diseño que me llevaron a tener que replantearme muchas de las cosas hechas previamente. No obstante, fue una muy buena experiencia, dado que una vez superados los problemas iniciales, el desarrollar la app fue una experiencia que me ayudó a entender varios temas aplicados en un contexto fuera del ámbito de un ejercicio de práctica, así como un motivo de inspiracion para un proyecto perosnal
Presentarse brevemente. Contar su experiencia programando y lo que significó para vos este trabajo (¿fue un desafío? ¿fue fácil? ¿aprendiste? ¿te divertiste? etc...).

## Resumen

[Imagen pendiente]
La aplicación permite simular el control de un cibercafé, permitiendo habilitar dispositivos (computadoras y telefonos), finalizar su uso y calcula los diversos montos a cobrar en base al tiempo de uso. La misma tambien informa al usuario de los requisitos del cliente, y destaca los dispositivos que cumplen los requisitos del mismo utilizando un código de colores para informar a simple vista qué dispositivos cumplen con estos requisitos, así como su estado actual

## Diagrama de clases


## Justificación técnica


**Clases y métodos Métodos estáticos:** Se aplica en la clase Cibercafe, la cual es estática. Decidí implementarlo de esta forma porque, en el ámbito de la aplicación, no existirían múltiples instancias del cibercafé, y los métodos con los que trabaja son independientes de cualquier tipo de instancia. Métodos como cobrar por el alquiler de un dispositivo realizan la misma tarea, de la misma forma, independientemente de las instancias que reciba como paramtro

**P.O.O. - Abstracción:** Todas las clases implementadas son una abstraccion de sus contrapartes reales. El ejemplo que destaco es la clase Cliente. Un Cliente no deja de ser una instancia de una persona, y una persona contiene mucha mas informacion que la contenida en esta aplicacion (informacion como peso, fecha de nacimineto, raza/etnia, nacionalidad, etc. son datos propios de cada una de estas instancias, pero que no son relevantes bajo la lógica de negocio actual.

**Clases de instancia:** Para esto, destaco las clases Computadora y Telefono. Cada uno de los objetos de estas clases creados en la aplicacion representa objetos distintos, con datos propios independientes del resto

**Sobrecargas:**
  **-De métodos:** Para esta seccion, destaco los métodos Cobrar dentro de la clase Cibercafé. La razon por la cual decidí implementar una sobrecarga es que, al momento de generar un historial para simular operaciones previas, la hora de finalizacion del dispositivo es generada de forma aleatoria. En cambio, durante la ejecucion de la aplicacion, al finalizar el uso de un dispositivo la hora de finalizacion debe ser el instante en que confirmé la finalizacion
  **-De constructores:** Aquí, los constructores sobrecargados se encuentran en la clase Cliente. Esto se debe a que un cliente no necesariamente debe tener una necesidad para cada cosa. Un cliente puede tener necesidad de utilizar solamente Office, por poner un ejemplo, pero no necesitar auriculares, mientras que un cliente que espera poder navegar por internet o comunicarse utilizando un programa de mensajería tal vez tenga interes en que una computadora tenga acceso a ciertos periféricos. También, un cliente que necesite un telefono no tiene necesidad de sofware, juego o periferico alguno
  **-De operadores:** Nuevamente, destaco la clase cliente, la cual contiene múltiples sobrecargas, tanto de igualdad como de adicion y resta. Decidí implementar estas sobrecargas para no solamente poder realizar de forma rápida una verificacion de que un dispositivo cuente con los requisitos del cliente, sino que tambien permite de forma rápida agregar o quitar un cliente de la cola de clientes. 
  
**Windows Forms:** Destaco en esta seccion el formulario principal, el cual forma la interfaz de usuario principal. No solamente eso, sino que decidi incluir formularios para mostrar el listado de clientes en espera, el historial y la ventana de ayuda. La razon por la cual decidí utilizar subformularios es para organizar mejor la informacion. Además, estos pueden hacerse de forma no modal, lo cual permite revisar estas ventanas sin tener que interrumpir el uso de la aplicacion

**Colecciones:** Aqui, destaco las colecciones contenidas en la clase Computadora. Cada computadora cuenta con un listado de software, juegos y perifericos, así como un diccionario para las especificaciones. La razon por la cual decidí implementar las listas es por la capacidad de autogestion, lo cual en el contexto de una computadora, en la cual se puede añadir o eliminar software con facilidad, haría mas eficiente el uso de las listas que el de arrays. En cunato a las especificaciones, la razon por la cual decdi implementarlo en un diccionario es que muchos de los componentes de una computadora son únicos e irrepetibles (una computadora, solamente tiene un procesador central, o una sola placa madre), lo cual hace que la propiedad de los diccionarios de tener una única clave sea ideal para listar el hardware del equipo

**P.O.O. - Encapsulamiento:** Destaco la clase Dispositivo, la cual tiene múltiples propiedades encapsuladas (ID, Fracciones asignadas, estado, etc.). Decidí encapsular estas propiedades para ocultar datos de la implementacion de esta clase, impidiendo el libre acceso público a los atributos del mismo, solamente mostrando al informacion relevante para el contexto de la aplicacion, para evitar modificaciones de campos desde lugares no deseados

**Enumerados:** Destaco el enumerado TipoLlamada, el cual representa los distintos tipos de llamada (local, larga distancia o internacional). Decidí implementar este enumerado de esta forma porque me permite acotar los posibles valores que puedan asignarse a un tipo de llamada, dado que los 3 casos mencionados cubren el espectro de posibles llamadas a realizar

**P.O.O - Herencia y polimorfismo, Clases abstractas:** Dada la estrecha relacion entre los temas mencionados, prefiero comentar los tres juntos utilizando el mismo ejemplo, la clase abstracta Dispositivo. Decidí implementar esta clase como abstracta porque los atributos y métodos que contiene son comunes a las dos clases que heredan de ésta: Computadora y Telefono. No obstante, un dispositivo en si no es un objeto concreto, sino que es una generalizacion aplicada a, en este caso, un dispositivo electrónico. El polimorfismo puede verse principalmente en el form principal, en donde utilizo la variable dispositivoSeleccionado para realizar acciones comunes a ambos tipos de dispositivo, obteniendo resultados propios de la instancia del dispositivo

**Clases selladas** Decidi sellar la clase Cliente. La razon por la que tomé esta decision es porque en la lógica de negocio, no tendría sentido hacer una division en el tipo de cliente, la misma persona que hoy pide una cabina telefónica mañana podría pedir una computadora. Realizar una especiación de clientes sería innecesario

## Propuesta de valor agregado
