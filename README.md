# design-patterns-via-csharp
This repository contains common design patterns, written via C#

# Pattern List
## Creational Patterns
- [x] Singleton
- [x] Factory Method
- [x] Abstract Factory
- [x] Builder
- [ ] Prototype

## Structural Patterns
- [ ] Adapter
- [ ] Bridge
- [ ] Composite
- [ ] Decorator
- [ ] Facade
- [ ] Flyweight
- [ ] Proxy

## Behavioral Patterns
- [ ] Chain of Responsibility
- [ ] Command
- [ ] Interpreter
- [ ] Iterator
- [ ] Mediator
- [ ] Memento
- [ ] Observer
- [ ] State
- [ ] Strategy
- [ ] Template Method
- [ ] Visitor

## Concurrency Patterns
- [ ] Thread Pool
- [ ] Producer-Consumer
- [ ] Async/Await (Task-Based Asynchronous Pattern)
- [ ] Actor Model


# Patterns Explanations/Keys
## Singleton
- Singleton pattern is a creational pattern that ensures a class has only one instance and provides a global point of access to it.
- Singleton pattern is used when a class in a program should have only one instance available to all clients.
- Singleton pattern is used when we need to provide a global point of access to a class.
- Singleton pattern is used when we need to control concurrent access to a resource.

## Factory Method
- Factory Method pattern is a creational pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
- Factory Method pattern is used when a class can't anticipate the class of objects it must create.
- Factory Method pattern is used when a class wants its subclasses to specify the objects it creates.
- Factory Method pattern is used when a class wants to localize the knowledge of which class gets created.

## Abstract Factory
- Abstract Factory pattern is a creational pattern that provides an interface for creating families of related or dependent objects without specifying their concrete classes.
- Abstract Factory pattern is used when a system should be independent of how its objects are created, composed, and represented.
- Abstract Factory pattern is used when a system should be configured with one of multiple families of objects.
- Abstract Factory pattern is used when a family of related product objects is designed to be used together, and you need to enforce this constraint.

## Builder
- Builder pattern is a creational pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.
- Builder pattern is used when an object needs different representations and the construction process is independent of the main system.
- Builder pattern is used when you want to construct a complex object step by step and the construction process should be independent of the system.
- Builder pattern is used when you want to construct an object with a lot of configuration options.

## Prototype
- Prototype pattern is a creational pattern that lets you copy existing objects without making your code dependent on their classes.
- Prototype pattern is used when an object needs to be copied or cloned.
- Prototype pattern is used when you want to avoid subclasses of an object creator in the client application, like the factory method pattern does.
- Prototype pattern is used when you want to avoid the inherent cost of creating a new object in the standard way (e.g., using the 'new' keyword) when it may actually be prohibitively expensive for a given application.