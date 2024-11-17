// Call design patterns at runtime

#region Adapter Pattern

Console.WriteLine("Adapter Pattern");

var adaptee = new Adaptee();
var target = new Adapter(adaptee);

target.Request();

Console.WriteLine(Environment.NewLine);

#endregion

return;