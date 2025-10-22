using srp;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Updating Client");

var notify = new Notify(new Client());

notify.NotifyClient();