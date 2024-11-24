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
- [x] Interpreter
- [x] Iterator
- [x] Mediator
- [x] Memento
- [x] Observer
- [x] State
- [x] Strategy
- [x] Template Method
- [x] Visitor

## Concurrency Patterns

- [x] Thread Pool
- [x] Producer-Consumer
- [x] Async/Await (Task-Based Asynchronous Pattern)
- [x] Actor Model

# Patterns Explanations/Keys

## Singleton

- Singleton pattern is a creational pattern that ensures a class has only one instance and provides a global point of
  access to it.
- Singleton pattern is used when a class in a program should have only one instance available to all clients.
- Singleton pattern is used when we need to provide a global point of access to a class.
- Singleton pattern is used when we need to control concurrent access to a resource.

## Factory Method

- Factory Method pattern is a creational pattern that provides an interface for creating objects in a superclass, but
  allows subclasses to alter the type of objects that will be created.
- Factory Method pattern is used when a class can't anticipate the class of objects it must create.
- Factory Method pattern is used when a class wants its subclasses to specify the objects it creates.
- Factory Method pattern is used when a class wants to localize the knowledge of which class gets created.

## Abstract Factory

- Abstract Factory pattern is a creational pattern that provides an interface for creating families of related or
  dependent objects without specifying their concrete classes.
- Abstract Factory pattern is used when a system should be independent of how its objects are created, composed, and
  represented.
- Abstract Factory pattern is used when a system should be configured with one of multiple families of objects.
- Abstract Factory pattern is used when a family of related product objects is designed to be used together, and you
  need to enforce this constraint.

## Builder

- Builder pattern is a creational pattern that lets you construct complex objects step by step. The pattern allows you
  to produce different types and representations of an object using the same construction code.
- Builder pattern is used when an object needs different representations and the construction process is independent of
  the main system.
- Builder pattern is used when you want to construct a complex object step by step and the construction process should
  be independent of the system.
- Builder pattern is used when you want to construct an object with a lot of configuration options.

## Prototype

- Prototype pattern is a creational pattern that lets you copy existing objects without making your code dependent on
  their classes.
- Prototype pattern is used when an object needs to be copied or cloned.
- Prototype pattern is used when you want to avoid subclasses of an object creator in the client application, like the
  factory method pattern does.
- Prototype pattern is used when you want to avoid the inherent cost of creating a new object in the standard way (e.g.,
  using the 'new' keyword) when it may actually be prohibitively expensive for a given application.

## Adapter

- Adapter pattern is a structural pattern that allows objects with incompatible interfaces to collaborate.
- Adapter pattern is used when you want to use an existing class, and its interface does not match the one you need.
- Adapter pattern is used when you want to create a reusable class that cooperates with unrelated or unforeseen classes,
  that is, classes that don't necessarily have compatible interfaces.
- Adapter pattern is used when you want to increase transparency of classes' interfaces so that they can work together.

## Bridge

- Bridge pattern is a structural pattern that lets you split a large class or a set of closely related classes into two
  separate hierarchies—abstraction and implementation—which can be developed independently of each other.
- Bridge pattern is used when you want to avoid a permanent binding between an abstraction and its implementation.
- Bridge pattern is used when you need to share an implementation among multiple objects.
- Bridge pattern is used when you want to extend a class in several orthogonal (independent) ways.

## Composite

- Composite pattern is a structural pattern that lets you compose objects into tree structures to represent part-whole
  hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
- Composite pattern is used when you want to represent part-whole hierarchies of objects.
- Composite pattern is used when you want clients to be able to ignore the difference between compositions of objects
  and individual objects. Clients will treat all objects in the composite structure uniformly.
- Composite pattern is used when you want to model objects into tree structures to represent part-whole hierarchies.

## Decorator

- Decorator pattern is a structural pattern that lets you attach new behaviors to objects by placing these objects
  inside special wrapper objects that contain the new behaviors.
- Decorator pattern is used when you want to add new functionality to an object without changing its class.
- Decorator pattern is used when you want to add several behaviors to an object, and it's not feasible to augment the
  object with every possible combination of behaviors.
- Decorator pattern is used when you want to divide a monolithic class that has several behaviors that can be divided
  into several smaller classes.

## Facade

- Facade pattern is a structural pattern that provides a simplified interface to a library, a framework, or any other
  complex set of classes.
- Facade pattern is used when you want to provide a simple interface to a complex subsystem.
- Facade pattern is used when you want to structure a subsystem into layers.
- Facade pattern is used when you want to decouple a subsystem from clients and other subsystems.

## Flyweight

- Flyweight pattern is a structural pattern that lets you fit more objects into the available amount of RAM by sharing
  common parts of state between multiple objects, instead of keeping `all the data in each object.
- Flyweight pattern is used when you need to create a large number of similar objects.
- Flyweight pattern is used when the storage costs are high because of the quantity of objects.
- Flyweight pattern is used when most object state can be made extrinsic.

## Proxy

- Proxy pattern is a structural pattern that lets you provide a substitute or placeholder for another object. A proxy
  controls access to the original object, allowing you to perform something either before or after the request gets
  through to the original object.
- Proxy pattern is used when you want to add a level of security to the original object.
- Proxy pattern is used when you want to control access to the original object.
- Proxy pattern is used when you want to defer the full cost of creating and initializing an object until it is actually
  needed.

## Chain of Responsibility

- Chain of Responsibility pattern is a behavioral pattern that lets you pass requests along a chain of handlers. Upon
  receiving a request, each handler decides either to process the request or to pass it along the chain.
- Chain of Responsibility pattern is used when you want to process a request one of several ways.
- Chain of Responsibility pattern is used when the set of objects that can handle a request should be specified
  dynamically.
- Chain of Responsibility pattern is used when you want to issue a request to one of several objects without specifying
  the receiver explicitly.

## Command

- Command pattern is a behavioral pattern that turns a request into a stand-alone object that contains all information
  about the request. This transformation lets you parameterize methods with different requests, delay or queue a
  request's execution, and support undoable operations.
- Command pattern is used when you want to parameterize objects with operations.
- Command pattern is used when you want to queue operations, schedule their execution
- Command pattern is used when you want to support undoable operations.

## Interpreter

- Interpreter pattern is a behavioral pattern that specifies how to evaluate sentences in a language. The basic idea is
  to have a class for each symbol (terminal or nonterminal) in a specialized computer language.
- Interpreter pattern is used when you want to interpret a language grammar.
- Interpreter pattern is used when the grammar is simple.
- Interpreter pattern is used when efficiency is not a critical concern.

## Iterator

- Iterator pattern is a behavioral pattern that lets you traverse elements of a collection without exposing its
  underlying representation (list, stack, tree, etc.).
- Iterator pattern is used when you want to traverse a collection of elements without exposing its internal structure.
- Iterator pattern is used when you want to provide a uniform interface for traversing different collections.
- Iterator pattern is used when you want to provide multiple traversals of a collection.

## Mediator

- Mediator pattern is a behavioral pattern that lets you reduce chaotic dependencies between objects. The pattern
  restricts direct communications between the objects and forces them to collaborate only via a mediator object.
- Mediator pattern is used when you want to reduce the direct dependencies between objects.
- Mediator pattern is used when you want to centralize the control of relationships between objects.
- Mediator pattern is used when you want to reuse an object independently of the objects it communicates with.

## Memento

- Memento pattern is a behavioral pattern that lets you save and restore the previous state of an object without
  revealing the details of its implementation.
- Memento pattern is used when you want to save the state of an object to be able to restore it later.
- Memento pattern is used when you need to restore the state of an object to a previous state.
- Memento pattern is used when direct access to the state of an object would expose implementation details and break the
  object's encapsulation.

## Observer

- Observer pattern is a behavioral pattern that establishes a one-to-many dependency between objects. When one object (
  the subject) changes state, all its dependents (observers) are notified automatically.
- Observer pattern is used when an object’s state changes need to be communicated to multiple other objects without
  tightly coupling them.
- Observer pattern is used when you want to implement a publish-subscribe system where subscribers dynamically register
  and unregister with the publisher.
- Observer pattern is used when you want to ensure that dependent objects stay consistent with the subject’s state in
  real-time.

## State

- State pattern is a behavioral pattern that allows an object to change its behavior when its internal state changes.
  The object appears to change its class dynamically.
- State pattern is used when an object’s behavior depends on its state and must change its behavior at runtime based on
  that state.
- State pattern is used when you want to eliminate complex conditionals (e.g., if-else or switch statements) that handle
  state-specific behavior.
- State pattern is used when you want to make state transitions explicit and easier to manage by encapsulating
  state-specific logic into separate classes.`

## Strategy

- Strategy pattern is a behavioral pattern that defines a family of algorithms, encapsulates each one, and makes them
  interchangeable. This allows the algorithm to vary independently from the clients that use it.
- Strategy pattern is used when you want to define multiple algorithms for a task and allow the client to choose or
  switch between them dynamically.
- Strategy pattern is used when you want to avoid conditional statements for selecting behaviors at runtime.
- Strategy pattern is used when you want to isolate algorithm-specific logic and keep it independent of the main
  application logic.
- Strategy pattern is used when you want to make an application flexible and open to adding new algorithms without
  modifying existing code.

## Template Method

- Template Method pattern is a behavioral design pattern that defines the skeleton of an algorithm in a base class,
  deferring some steps to subclasses.
- Template Method pattern is used when the structure of an algorithm is consistent across different contexts, but some
  steps need to vary.
- Template Method pattern is used to enforce a sequence of operations while allowing subclasses to implement specific
  parts of the logic.
- Template Method pattern is used when you want to promote code reuse by keeping common logic in a single location and
  delegating specific behavior to subclasses.

## Visitor

- Visitor pattern is a behavioral pattern that allows you to add new operations to an object structure without modifying
  the objects themselves.
- Visitor pattern is used when you want to separate algorithms or behaviors from the objects they operate on, keeping
  the code more modular and maintainable.
- Visitor pattern is used when an object structure contains many different types of objects, and you need to perform
  distinct operations on each type.
- Visitor pattern is used when you want to add new behaviors to an existing class hierarchy without changing its code.

## Thread Pool

- Thread Pool pattern is a structural pattern that manages a pool of pre-initialized threads, which can be reused to
  perform multiple tasks, avoiding the overhead of creating and destroying threads repeatedly.
- Thread Pool pattern is used when there are a large number of short-lived tasks that need to be executed efficiently.
- Thread Pool pattern is used when the cost of creating and destroying threads is high, and thread reuse can improve
  performance.
- Thread Pool pattern is used when you want to control and limit the number of concurrent threads to optimize resource
  utilization.

## Producer-Consumer

- Producer-Consumer pattern is a concurrency design pattern where producers generate data and place it into a shared
  buffer, while consumers retrieve and process the data.
- Producer-Consumer pattern is used to decouple the production and consumption of data, allowing them to operate at
  independent speeds.
- Producer-Consumer pattern is used when you want to manage a pipeline of tasks between producers and consumers using a
  thread-safe buffer or queue.
- Producer-Consumer pattern is used when multiple producers and consumers need to coordinate efficiently while avoiding
  issues like race conditions or resource contention.

## Async/Await

- Async/Await is a programming used to write asynchronous, non-blocking code in a way that looks and behaves like
  synchronous code.
- Async/Await is used when an operation might take time to complete (e.g., network requests, file I/O) and you want to
  avoid blocking the main thread.
- Async/Await is used when you need to keep the application responsive during long-running operations.
- Async/Await is used when you want to simplify complex callback-based code, making it easier to read, write, and
  maintain.

## Actor Model

- Actor Model is a concurrency design pattern that treats "actors" as the fundamental units of computation,
  encapsulating state and behavior.
- Actor Model is used when you need to build highly scalable, distributed, or parallel systems where components work
  independently and communicate asynchronously.
- Actor Model is used when you want to manage concurrency without shared state, avoiding common issues like race
  conditions and deadlocks.
- Actor Model is used when you need to model complex workflows or systems where tasks are processed by independent units
  that interact only through message-passing.