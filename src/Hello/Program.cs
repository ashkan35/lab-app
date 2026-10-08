using System.Reflection;

var mode = Assembly.GetEntryAssembly()!
    .GetCustomAttributes<AssemblyMetadataAttribute>()
    .First(a => a.Key == "LibraryReferenceMode").Value;

Console.WriteLine($"Mode: {mode}");
Console.WriteLine(Greeter.Greet.Hello("Ashkan"));
