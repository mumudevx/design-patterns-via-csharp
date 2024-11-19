# design-patterns-via-csharp
This repository contains common design patterns, written via C#

# Pattern List
## Creational Patterns
- [x] Singleton
- [x] Factory Method
- [x] Abstract Factory
- [x] Builder
- [x] Prototype

## Structural Patterns
- [x] Adapter
- [x] Bridge
- [x] Composite
- [x] Decorator
- [x] Facade
- [x] Flyweight
- [x] Proxy

## Behavioral Patterns
- [x] Chain of Responsibility
- [x] Command
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

## Adapter
- Adapter pattern is a structural pattern that allows objects with incompatible interfaces to collaborate.
- Adapter pattern is used when you want to use an existing class, and its interface does not match the one you need.
- Adapter pattern is used when you want to create a reusable class that cooperates with unrelated or unforeseen classes, that is, classes that don't necessarily have compatible interfaces.
- Adapter pattern is used when you want to increase transparency of classes' interfaces so that they can work together.

## Bridge
- Bridge pattern is a structural pattern that lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.
- Bridge pattern is used when you want to avoid a permanent binding between an abstraction and its implementation.
- Bridge pattern is used when you need to share an implementation among multiple objects.
- Bridge pattern is used when you want to extend a class in several orthogonal (independent) ways.

## Composite
- Composite pattern is a structural pattern that lets you compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
- Composite pattern is used when you want to represent part-whole hierarchies of objects.
- Composite pattern is used when you want clients to be able to ignore the difference between compositions of objects and individual objects. Clients will treat all objects in the composite structure uniformly.
- Composite pattern is used when you want to model objects into tree structures to represent part-whole hierarchies.

## Decorator
- Decorator pattern is a structural pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the new behaviors.
- Decorator pattern is used when you want to add new functionality to an object without changing its class.
- Decorator pattern is used when you want to add several behaviors to an object, and it's not feasible to augment the object with every possible combination of behaviors.
- Decorator pattern is used when you want to divide a monolithic class that has several behaviors that can be divided into several smaller classes.

## Facade
- Facade pattern is a structural pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.
- Facade pattern is used when you want to provide a simple interface to a complex subsystem.
- Facade pattern is used when you want to structure a subsystem into layers.
- Facade pattern is used when you want to decouple a subsystem from clients and other subsystems.

## Flyweight
- Flyweight pattern is a structural pattern that lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects, instead of keeping `all the data in each object.
- Flyweight pattern is used when you need to create a large number of similar objects.
- Flyweight pattern is used when the storage costs are high because of the quantity of objects.
- Flyweight pattern is used when most object state can be made extrinsic.

## Proxy
- Proxy pattern is a structural pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.
- Proxy pattern is used when you want to add a level of security to the original object.
- Proxy pattern is used when you want to control access to the original object.
- Proxy pattern is used when you want to defer the full cost of creating and initializing an object until it is actually needed.

## Chain of Responsibility
- Chain of Responsibility pattern is a behavioral pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it along the chain.
- Chain of Responsibility pattern is used when you want to process a request one of several ways.
- Chain of Responsibility pattern is used when the set of objects that can handle a request should be specified dynamically.
- Chain of Responsibility pattern is used when you want to issue a request to one of several objects without specifying the receiver explicitly.

## Command
- Command pattern is a behavioral pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you parameterize methods with different requests, delay or queue a request's execution, and support undoable operations.
- Command pattern is used when you want to parameterize objects with operations.
- Command pattern is used when you want to queue operations, schedule their execution
- Command pattern is used when you want to support undoable operations.