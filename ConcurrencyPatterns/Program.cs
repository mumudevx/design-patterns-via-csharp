﻿#region Thread Pool Pattern

Console.WriteLine("Thread Pool Pattern");

// Queue to simulate incoming orders
var orderQueue = new ConcurrentQueue<int>();
for (var i = 1; i <= 10; i++)
{
    orderQueue.Enqueue(i);
}

// Using ThreadPool to process orders
while (orderQueue.TryDequeue(out var orderNumber))
    ThreadPool.QueueUserWorkItem(Processor.ProcessOrder, orderNumber);

Console.WriteLine("All orders have been queued for processing. Press any key to continue, after completion.");

Console.ReadKey();

Console.WriteLine(Environment.NewLine);

#endregion

#region Producer Consumer Pattern

Console.WriteLine("Producer - Consumer Pattern");

var ordersQueue = new BlockingCollection<string>(boundedCapacity: 10);

// Producers
var waiterOne = new Producer(ordersQueue, "Waiter 1");
var waiterTwo = new Producer(ordersQueue, "Waiter 2");

var produceJobOne = Task.Run(() => waiterOne.Produce());
var produceJobTwo = Task.Run(() => waiterTwo.Produce());

// Consumers
var chefOne = new Consumer(ordersQueue, "Chef 1");
var chefTwo = new Consumer(ordersQueue, "Chef 2");

var consumeJobOne = Task.Run(() => chefOne.Consume());
var consumeJobTwo = Task.Run(() => chefTwo.Consume());

Task.WaitAll(produceJobOne, produceJobTwo);
ordersQueue.CompleteAdding();

Task.WaitAll(consumeJobOne, consumeJobTwo);
Console.WriteLine("All orders have been processed!");

Console.WriteLine(Environment.NewLine);

#endregion

#region Async/Await

Console.WriteLine("Async/Await");

var todoService = new TodoService();

var todoItem = await todoService.GetById(1);

if (todoItem == null)
{
    Console.WriteLine("Todo item was not found.");
    return;
}

Console.WriteLine($"{todoItem.Id} - {todoItem.Title} (Completed:{todoItem.Completed})");

Console.WriteLine(Environment.NewLine);

#endregion

#region Actor Model

Console.WriteLine("Actor Model");

var orderActor = new OrderActor();
var paymentActor = new PaymentActor();
var deliveryActor = new DeliveryActor();

const string orderDetails = "Order #854436";

orderActor.ProcessOrder(orderDetails);
paymentActor.ProcessPayment(orderDetails);
deliveryActor.ScheduleDelivery(orderDetails);

Console.WriteLine("Press any key to continue");
Console.ReadKey();

Console.WriteLine(Environment.NewLine);

#endregion