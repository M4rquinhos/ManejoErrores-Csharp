using ManejoErrores;
using System.Diagnostics;

var escritorConsola = new TextWriterTraceListener(System.Console.Out);
var escritorPersonalizado = new TextWriterTraceListener(new EscritotPersonalizado());
Trace.Listeners.Add(escritorConsola);
Trace.Listeners.Add(escritorPersonalizado);

Console.WriteLine("Esta linea se ha ejecutado");

var cantidad1 = 4;

Console.WriteLine($"El valor de la variable es: {cantidad1}");


Debug.WriteLine("Este mensaje solo aparece en modo debug");




Console.WriteLine("Antes del error");

throw new Exception();

Console.WriteLine("Despues del error");