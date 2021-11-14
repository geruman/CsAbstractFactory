# Abstract factory

Es un patr�n creacional. [Link descripci�n](https://sourcemaking.com/design_patterns/abstract_factory)

Este patr�n se utiliza para generar familias de objetos a trav�s del patron factory, donde el cliente no conoce la implementaci�n del objeto concreto en s� si no que consigue las instancias a trav�s de una factor�a elegida previamente.

## Diagrama de clases
![UML](abstract_factory.jpg)

## SOLID

* Single responsibility

Cada Factoria tiene como responsabilidad crear los objetos de una misma familia. Solo har�a falta modificarlas en caso de que se agreguen objetos a la familia o cambie el m�todo de instanciaci�n de los objetos existentes.

* Open/Closed principle

El abstract factory entra en conflicto con este principio cuando se necesita implementar la creaci�n de un nuevo objeto de la familia, llevando a grandes refactorizaciones entre varias factorias para poder agregar un nuevo objeto a la familia 

* Liskov substitution

Las factorias se pueden intercambiar perfectamente gracias a que comparten una interfaz en com�n.

* Interface segregation

Podemos encontrarnos con un problema de segregaci�n de interfaz cuando una familia de objetos tiene m�s objetos que otra familia, ya que la interfaz de abstract factory debe definir todos los m�todos de creaci�n compartidos por las factorias concretas

* Dependency inversion

Las factorias ayudan a cumplir con este principio dentro del sistema, pero la factoria en s� debe conocer la implementaci�n concreta de una interfaz a instanciar.

